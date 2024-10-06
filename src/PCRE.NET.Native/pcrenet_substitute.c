#include "pcrenet.h"

typedef int (*substitute_callout_fn)(pcre2_substitute_callout_block*, void*);

typedef struct
{
    pcre2_code* code;
    uint16_t* subject;
    uint32_t subject_length;
    uint32_t start_index;
    uint32_t additional_options;
    match_settings settings;
    uint16_t* replacement;
    uint32_t replacement_length;
    uint16_t* buffer;
    uint32_t buffer_length;
    substitute_callout_fn callout;
    void* callout_data;
} pcrenet_substitute_input;

typedef struct
{
    int32_t result_code;
    uint16_t* output;
    size_t output_length;
    uint8_t output_on_heap;
} pcrenet_substitute_result;

typedef struct
{
    int* buffer;
    size_t buffer_size;
    size_t count;
    size_t replayed;
} replay_queue;

typedef struct
{
    const pcrenet_substitute_input* input;
    replay_queue callout_queue;
} substitute_callout_data;

static void replay_queue_init(replay_queue* queue)
{
    queue->buffer = NULL;
    queue->buffer_size = 0;
    queue->count = 0;
    queue->replayed = 0;
}

static void replay_queue_free(replay_queue* queue)
{
    if (queue->buffer)
        free(queue->buffer);

    replay_queue_init(queue);
}

static void replay_queue_start_replay(replay_queue* queue)
{
    queue->replayed = 0;
}

static int replay_queue_try_dequeue(replay_queue* queue, int* result)
{
    if (!queue->buffer && queue->buffer_size)
        return 0; // Invalid queue

    if (queue->replayed < queue->count)
    {
        *result = queue->buffer[queue->replayed++];
        return 1;
    }

    return 0;
}

static void replay_queue_try_enqueue(replay_queue* queue, int result)
{
    if (!queue->buffer && queue->buffer_size)
        return; // Invalid queue

    if (queue->count == queue->buffer_size)
    {
        const size_t new_size = max(8, 2 * queue->buffer_size);
        int* new_buf = realloc(queue->buffer, new_size * sizeof(int));
        if (!new_buf)
            return;

        queue->buffer = new_buf;
        queue->buffer_size = new_size;
    }

    queue->buffer[queue->count++] = result;
    queue->replayed = queue->count;
}

static void free_result_memory(pcrenet_substitute_result* result)
{
    if (!result)
        return;

    if (result->output && result->output_on_heap)
        free(result->output);

    result->output = NULL;
    result->output_length = 0;
    result->output_on_heap = 0;
}

static int substitute_callout_handler(pcre2_substitute_callout_block* block, void* data_ptr)
{
    substitute_callout_data* data = data_ptr;

    int result;
    if (replay_queue_try_dequeue(&data->callout_queue, &result))
        return result;

    result = data->input->callout(block, data->input->callout_data);

    replay_queue_try_enqueue(&data->callout_queue, result);
    return result;
}

static int call_substitute(const pcrenet_substitute_input* input,
                           const uint32_t additional_options,
                           PCRE2_UCHAR* output,
                           PCRE2_SIZE* output_length,
                           pcre2_match_data* match_data,
                           pcre2_match_context* match_context)
{
    return pcre2_substitute(
        input->code,
        input->subject,
        input->subject_length,
        input->start_index,
        input->additional_options | additional_options,
        match_data,
        match_context,
        input->replacement,
        input->replacement_length,
        output,
        output_length
    );
}

static void substitute_simple(const pcrenet_substitute_input* input,
                              pcrenet_substitute_result* result,
                              pcre2_match_data* match_data,
                              pcre2_match_context* match_context)
{
    // Try to substitute in one or two passes max using the PCRE2_SUBSTITUTE_OVERFLOW_LENGTH option

    result->output = input->buffer;
    result->output_length = 0;
    result->output_on_heap = 0;

    PCRE2_SIZE output_length = input->buffer_length;

    result->result_code = call_substitute(
        input,
        PCRE2_SUBSTITUTE_OVERFLOW_LENGTH,
        result->output,
        &output_length,
        match_data,
        match_context
    );

    // Success on first pass
    if (result->result_code >= 0)
    {
        result->output_length = output_length;
        return;
    }

    // Second pass required
    if (result->result_code == PCRE2_ERROR_NOMEMORY)
    {
        result->output = malloc(output_length * sizeof(PCRE2_UCHAR));

        if (!result->output)
            return;

        result->output_on_heap = 1;

        result->result_code = call_substitute(
            input,
            PCRE2_NO_UTF_CHECK,
            result->output,
            &output_length,
            match_data,
            match_context
        );

        // Success on second pass
        if (result->result_code >= 0)
        {
            result->output_length = output_length;
            return;
        }
    }

    // Error
    free_result_memory(result);
}

static void substitute_with_callout(const pcrenet_substitute_input* input,
                                    pcrenet_substitute_result* result,
                                    pcre2_match_data* match_data,
                                    pcre2_match_context* match_context)
{
    result->output = input->buffer;
    result->output_length = 0;
    result->output_on_heap = 0;

    // Available buffer size, in characters
    PCRE2_SIZE buffer_length = input->buffer_length;

    // Same as buffer_length, but will be overwritten by pcre2_substitute
    PCRE2_SIZE output_length = buffer_length;

    substitute_callout_data callout_data = {
        .input = input
    };

    replay_queue_init(&callout_data.callout_queue);

    pcre2_set_substitute_callout(match_context, &substitute_callout_handler, &callout_data);

    while (1)
    {
        replay_queue_start_replay(&callout_data.callout_queue);

        result->result_code = call_substitute(
            input,
            0,
            result->output,
            &output_length,
            match_data,
            match_context
        );

        // Success
        if (result->result_code >= 0)
        {
            result->output_length = output_length;
            break;
        }

        // Output buffer is too small
        if (result->result_code == PCRE2_ERROR_NOMEMORY)
        {
            buffer_length *= 2;

            if (!result->output_on_heap)
            {
                result->output = malloc(buffer_length * sizeof(PCRE2_UCHAR));

                if (!result->output)
                    break;

                result->output_on_heap = 1;
            }
            else
            {
                uint16_t* new_buffer = realloc(result->output, buffer_length * sizeof(PCRE2_UCHAR));

                if (!new_buffer)
                {
                    free_result_memory(result);
                    break;
                }

                result->output = new_buffer;
            }

            output_length = buffer_length;
            continue;
        }

        // Error
        free_result_memory(result);
        break;
    }

    replay_queue_free(&callout_data.callout_queue);
}

PCRENET_EXPORT(void, substitute)(const pcrenet_substitute_input* input, pcrenet_substitute_result* result)
{
    pcre2_match_data* match_data = pcre2_match_data_create_from_pattern(input->code, NULL);
    pcre2_match_context* match_context = pcre2_match_context_create(NULL);

    apply_settings(&input->settings, match_context);

    if (!input->callout)
        substitute_simple(input, result, match_data, match_context);
    else
        substitute_with_callout(input, result, match_data, match_context);

    pcre2_match_context_free(match_context);
    pcre2_match_data_free(match_data);
}

PCRENET_EXPORT(void, substitute_result_free)(pcrenet_substitute_result* result)
{
    free_result_memory(result);
}
