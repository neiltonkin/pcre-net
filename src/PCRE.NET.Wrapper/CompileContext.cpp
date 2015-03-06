
#include "stdafx.h"
#include "CompileContext.h"

namespace PCRE {
	namespace Wrapper {

		CompileContext::CompileContext(String^ pattern)
		{
			if (pattern == nullptr)
				throw gcnew ArgumentNullException("pattern");

			_ctx = pcre2_compile_context_create(nullptr);
			_pattern = pattern;
		}

		CompileContext::~CompileContext()
		{
			this->!CompileContext();
		}

		CompileContext::!CompileContext()
		{
			if (_ctx)
			{
				pcre2_compile_context_free(_ctx);
				_ctx = nullptr;
			}
		}

		void CompileContext::NewLine::set(PCRE::Wrapper::NewLine value)
		{
			pcre2_set_newline(_ctx, static_cast<uint32_t>(value));
		}

		void CompileContext::BackslashR::set(PCRE::Wrapper::BackslashR value)
		{
			pcre2_set_bsr(_ctx, static_cast<uint32_t>(value));
		}

		void CompileContext::ParensNestLimit::set(uint32_t value)
		{
			pcre2_set_parens_nest_limit(_ctx, value);
		}
	}
}
