﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace PCRE.Internal
{
    internal static class PcreConstants
    {
        public const uint ANCHORED = 0x80000000;
        public const uint NO_UTF_CHECK = 0x40000000;
        public const uint ENDANCHORED = 0x20000000;
        public const uint ALLOW_EMPTY_CLASS = 0x00000001;
        public const uint ALT_BSUX = 0x00000002;
        public const uint AUTO_CALLOUT = 0x00000004;
        public const uint CASELESS = 0x00000008;
        public const uint DOLLAR_ENDONLY = 0x00000010;
        public const uint DOTALL = 0x00000020;
        public const uint DUPNAMES = 0x00000040;
        public const uint EXTENDED = 0x00000080;
        public const uint FIRSTLINE = 0x00000100;
        public const uint MATCH_UNSET_BACKREF = 0x00000200;
        public const uint MULTILINE = 0x00000400;
        public const uint NEVER_UCP = 0x00000800;
        public const uint NEVER_UTF = 0x00001000;
        public const uint NO_AUTO_CAPTURE = 0x00002000;
        public const uint NO_AUTO_POSSESS = 0x00004000;
        public const uint NO_DOTSTAR_ANCHOR = 0x00008000;
        public const uint NO_START_OPTIMIZE = 0x00010000;
        public const uint UCP = 0x00020000;
        public const uint UNGREEDY = 0x00040000;
        public const uint UTF = 0x00080000;
        public const uint NEVER_BACKSLASH_C = 0x00100000;
        public const uint ALT_CIRCUMFLEX = 0x00200000;
        public const uint ALT_VERBNAMES = 0x00400000;
        public const uint USE_OFFSET_LIMIT = 0x00800000;
        public const uint EXTENDED_MORE = 0x01000000;
        public const uint LITERAL = 0x02000000;
        public const uint MATCH_INVALID_UTF = 0x04000000;
        public const uint EXTRA_ALLOW_SURROGATE_ESCAPES = 0x00000001;
        public const uint EXTRA_BAD_ESCAPE_IS_LITERAL = 0x00000002;
        public const uint EXTRA_MATCH_WORD = 0x00000004;
        public const uint EXTRA_MATCH_LINE = 0x00000008;
        public const uint EXTRA_ESCAPED_CR_IS_LF = 0x00000010;
        public const uint EXTRA_ALT_BSUX = 0x00000020;
        public const uint JIT_COMPLETE = 0x00000001;
        public const uint JIT_PARTIAL_SOFT = 0x00000002;
        public const uint JIT_PARTIAL_HARD = 0x00000004;
        public const uint JIT_INVALID_UTF = 0x00000100;
        public const uint NOTBOL = 0x00000001;
        public const uint NOTEOL = 0x00000002;
        public const uint NOTEMPTY = 0x00000004;
        public const uint NOTEMPTY_ATSTART = 0x00000008;
        public const uint PARTIAL_SOFT = 0x00000010;
        public const uint PARTIAL_HARD = 0x00000020;
        public const uint DFA_RESTART = 0x00000040;
        public const uint DFA_SHORTEST = 0x00000080;
        public const uint SUBSTITUTE_GLOBAL = 0x00000100;
        public const uint SUBSTITUTE_EXTENDED = 0x00000200;
        public const uint SUBSTITUTE_UNSET_EMPTY = 0x00000400;
        public const uint SUBSTITUTE_UNKNOWN_UNSET = 0x00000800;
        public const uint SUBSTITUTE_OVERFLOW_LENGTH = 0x00001000;
        public const uint NO_JIT = 0x00002000;
        public const uint COPY_MATCHED_SUBJECT = 0x00004000;
        public const uint SUBSTITUTE_LITERAL = 0x00008000;
        public const uint SUBSTITUTE_MATCHED = 0x00010000;
        public const uint SUBSTITUTE_REPLACEMENT_ONLY = 0x00020000;
        public const uint CONVERT_UTF = 0x00000001;
        public const uint CONVERT_NO_UTF_CHECK = 0x00000002;
        public const uint CONVERT_POSIX_BASIC = 0x00000004;
        public const uint CONVERT_POSIX_EXTENDED = 0x00000008;
        public const uint CONVERT_GLOB = 0x00000010;
        public const uint CONVERT_GLOB_NO_WILD_SEPARATOR = 0x00000030;
        public const uint CONVERT_GLOB_NO_STARSTAR = 0x00000050;
        public const uint NEWLINE_CR = 1;
        public const uint NEWLINE_LF = 2;
        public const uint NEWLINE_CRLF = 3;
        public const uint NEWLINE_ANY = 4;
        public const uint NEWLINE_ANYCRLF = 5;
        public const uint NEWLINE_NUL = 6;
        public const uint BSR_UNICODE = 1;
        public const uint BSR_ANYCRLF = 2;
        public const int ERROR_END_BACKSLASH = 101;
        public const int ERROR_END_BACKSLASH_C = 102;
        public const int ERROR_UNKNOWN_ESCAPE = 103;
        public const int ERROR_QUANTIFIER_OUT_OF_ORDER = 104;
        public const int ERROR_QUANTIFIER_TOO_BIG = 105;
        public const int ERROR_MISSING_SQUARE_BRACKET = 106;
        public const int ERROR_ESCAPE_INVALID_IN_CLASS = 107;
        public const int ERROR_CLASS_RANGE_ORDER = 108;
        public const int ERROR_QUANTIFIER_INVALID = 109;
        public const int ERROR_INTERNAL_UNEXPECTED_REPEAT = 110;
        public const int ERROR_INVALID_AFTER_PARENS_QUERY = 111;
        public const int ERROR_POSIX_CLASS_NOT_IN_CLASS = 112;
        public const int ERROR_POSIX_NO_SUPPORT_COLLATING = 113;
        public const int ERROR_MISSING_CLOSING_PARENTHESIS = 114;
        public const int ERROR_BAD_SUBPATTERN_REFERENCE = 115;
        public const int ERROR_NULL_PATTERN = 116;
        public const int ERROR_BAD_OPTIONS = 117;
        public const int ERROR_MISSING_COMMENT_CLOSING = 118;
        public const int ERROR_PARENTHESES_NEST_TOO_DEEP = 119;
        public const int ERROR_PATTERN_TOO_LARGE = 120;
        public const int ERROR_HEAP_FAILED = 121;
        public const int ERROR_UNMATCHED_CLOSING_PARENTHESIS = 122;
        public const int ERROR_INTERNAL_CODE_OVERFLOW = 123;
        public const int ERROR_MISSING_CONDITION_CLOSING = 124;
        public const int ERROR_LOOKBEHIND_NOT_FIXED_LENGTH = 125;
        public const int ERROR_ZERO_RELATIVE_REFERENCE = 126;
        public const int ERROR_TOO_MANY_CONDITION_BRANCHES = 127;
        public const int ERROR_CONDITION_ASSERTION_EXPECTED = 128;
        public const int ERROR_BAD_RELATIVE_REFERENCE = 129;
        public const int ERROR_UNKNOWN_POSIX_CLASS = 130;
        public const int ERROR_INTERNAL_STUDY_ERROR = 131;
        public const int ERROR_UNICODE_NOT_SUPPORTED = 132;
        public const int ERROR_PARENTHESES_STACK_CHECK = 133;
        public const int ERROR_CODE_POINT_TOO_BIG = 134;
        public const int ERROR_LOOKBEHIND_TOO_COMPLICATED = 135;
        public const int ERROR_LOOKBEHIND_INVALID_BACKSLASH_C = 136;
        public const int ERROR_UNSUPPORTED_ESCAPE_SEQUENCE = 137;
        public const int ERROR_CALLOUT_NUMBER_TOO_BIG = 138;
        public const int ERROR_MISSING_CALLOUT_CLOSING = 139;
        public const int ERROR_ESCAPE_INVALID_IN_VERB = 140;
        public const int ERROR_UNRECOGNIZED_AFTER_QUERY_P = 141;
        public const int ERROR_MISSING_NAME_TERMINATOR = 142;
        public const int ERROR_DUPLICATE_SUBPATTERN_NAME = 143;
        public const int ERROR_INVALID_SUBPATTERN_NAME = 144;
        public const int ERROR_UNICODE_PROPERTIES_UNAVAILABLE = 145;
        public const int ERROR_MALFORMED_UNICODE_PROPERTY = 146;
        public const int ERROR_UNKNOWN_UNICODE_PROPERTY = 147;
        public const int ERROR_SUBPATTERN_NAME_TOO_LONG = 148;
        public const int ERROR_TOO_MANY_NAMED_SUBPATTERNS = 149;
        public const int ERROR_CLASS_INVALID_RANGE = 150;
        public const int ERROR_OCTAL_BYTE_TOO_BIG = 151;
        public const int ERROR_INTERNAL_OVERRAN_WORKSPACE = 152;
        public const int ERROR_INTERNAL_MISSING_SUBPATTERN = 153;
        public const int ERROR_DEFINE_TOO_MANY_BRANCHES = 154;
        public const int ERROR_BACKSLASH_O_MISSING_BRACE = 155;
        public const int ERROR_INTERNAL_UNKNOWN_NEWLINE = 156;
        public const int ERROR_BACKSLASH_G_SYNTAX = 157;
        public const int ERROR_PARENS_QUERY_R_MISSING_CLOSING = 158;
        public const int ERROR_VERB_ARGUMENT_NOT_ALLOWED = 159;
        public const int ERROR_VERB_UNKNOWN = 160;
        public const int ERROR_SUBPATTERN_NUMBER_TOO_BIG = 161;
        public const int ERROR_SUBPATTERN_NAME_EXPECTED = 162;
        public const int ERROR_INTERNAL_PARSED_OVERFLOW = 163;
        public const int ERROR_INVALID_OCTAL = 164;
        public const int ERROR_SUBPATTERN_NAMES_MISMATCH = 165;
        public const int ERROR_MARK_MISSING_ARGUMENT = 166;
        public const int ERROR_INVALID_HEXADECIMAL = 167;
        public const int ERROR_BACKSLASH_C_SYNTAX = 168;
        public const int ERROR_BACKSLASH_K_SYNTAX = 169;
        public const int ERROR_INTERNAL_BAD_CODE_LOOKBEHINDS = 170;
        public const int ERROR_BACKSLASH_N_IN_CLASS = 171;
        public const int ERROR_CALLOUT_STRING_TOO_LONG = 172;
        public const int ERROR_UNICODE_DISALLOWED_CODE_POINT = 173;
        public const int ERROR_UTF_IS_DISABLED = 174;
        public const int ERROR_UCP_IS_DISABLED = 175;
        public const int ERROR_VERB_NAME_TOO_LONG = 176;
        public const int ERROR_BACKSLASH_U_CODE_POINT_TOO_BIG = 177;
        public const int ERROR_MISSING_OCTAL_OR_HEX_DIGITS = 178;
        public const int ERROR_VERSION_CONDITION_SYNTAX = 179;
        public const int ERROR_INTERNAL_BAD_CODE_AUTO_POSSESS = 180;
        public const int ERROR_CALLOUT_NO_STRING_DELIMITER = 181;
        public const int ERROR_CALLOUT_BAD_STRING_DELIMITER = 182;
        public const int ERROR_BACKSLASH_C_CALLER_DISABLED = 183;
        public const int ERROR_QUERY_BARJX_NEST_TOO_DEEP = 184;
        public const int ERROR_BACKSLASH_C_LIBRARY_DISABLED = 185;
        public const int ERROR_PATTERN_TOO_COMPLICATED = 186;
        public const int ERROR_LOOKBEHIND_TOO_LONG = 187;
        public const int ERROR_PATTERN_STRING_TOO_LONG = 188;
        public const int ERROR_INTERNAL_BAD_CODE = 189;
        public const int ERROR_INTERNAL_BAD_CODE_IN_SKIP = 190;
        public const int ERROR_NO_SURROGATES_IN_UTF16 = 191;
        public const int ERROR_BAD_LITERAL_OPTIONS = 192;
        public const int ERROR_SUPPORTED_ONLY_IN_UNICODE = 193;
        public const int ERROR_INVALID_HYPHEN_IN_OPTIONS = 194;
        public const int ERROR_ALPHA_ASSERTION_UNKNOWN = 195;
        public const int ERROR_SCRIPT_RUN_NOT_AVAILABLE = 196;
        public const int ERROR_TOO_MANY_CAPTURES = 197;
        public const int ERROR_CONDITION_ATOMIC_ASSERTION_EXPECTED = 198;
        public const int ERROR_NOMATCH = -1;
        public const int ERROR_PARTIAL = -2;
        public const int ERROR_UTF8_ERR1 = -3;
        public const int ERROR_UTF8_ERR2 = -4;
        public const int ERROR_UTF8_ERR3 = -5;
        public const int ERROR_UTF8_ERR4 = -6;
        public const int ERROR_UTF8_ERR5 = -7;
        public const int ERROR_UTF8_ERR6 = -8;
        public const int ERROR_UTF8_ERR7 = -9;
        public const int ERROR_UTF8_ERR8 = -10;
        public const int ERROR_UTF8_ERR9 = -11;
        public const int ERROR_UTF8_ERR10 = -12;
        public const int ERROR_UTF8_ERR11 = -13;
        public const int ERROR_UTF8_ERR12 = -14;
        public const int ERROR_UTF8_ERR13 = -15;
        public const int ERROR_UTF8_ERR14 = -16;
        public const int ERROR_UTF8_ERR15 = -17;
        public const int ERROR_UTF8_ERR16 = -18;
        public const int ERROR_UTF8_ERR17 = -19;
        public const int ERROR_UTF8_ERR18 = -20;
        public const int ERROR_UTF8_ERR19 = -21;
        public const int ERROR_UTF8_ERR20 = -22;
        public const int ERROR_UTF8_ERR21 = -23;
        public const int ERROR_UTF16_ERR1 = -24;
        public const int ERROR_UTF16_ERR2 = -25;
        public const int ERROR_UTF16_ERR3 = -26;
        public const int ERROR_UTF32_ERR1 = -27;
        public const int ERROR_UTF32_ERR2 = -28;
        public const int ERROR_BADDATA = -29;
        public const int ERROR_MIXEDTABLES = -30;
        public const int ERROR_BADMAGIC = -31;
        public const int ERROR_BADMODE = -32;
        public const int ERROR_BADOFFSET = -33;
        public const int ERROR_BADOPTION = -34;
        public const int ERROR_BADREPLACEMENT = -35;
        public const int ERROR_BADUTFOFFSET = -36;
        public const int ERROR_CALLOUT = -37;
        public const int ERROR_DFA_BADRESTART = -38;
        public const int ERROR_DFA_RECURSE = -39;
        public const int ERROR_DFA_UCOND = -40;
        public const int ERROR_DFA_UFUNC = -41;
        public const int ERROR_DFA_UITEM = -42;
        public const int ERROR_DFA_WSSIZE = -43;
        public const int ERROR_INTERNAL = -44;
        public const int ERROR_JIT_BADOPTION = -45;
        public const int ERROR_JIT_STACKLIMIT = -46;
        public const int ERROR_MATCHLIMIT = -47;
        public const int ERROR_NOMEMORY = -48;
        public const int ERROR_NOSUBSTRING = -49;
        public const int ERROR_NOUNIQUESUBSTRING = -50;
        public const int ERROR_NULL = -51;
        public const int ERROR_RECURSELOOP = -52;
        public const int ERROR_DEPTHLIMIT = -53;
        public const int ERROR_UNAVAILABLE = -54;
        public const int ERROR_UNSET = -55;
        public const int ERROR_BADOFFSETLIMIT = -56;
        public const int ERROR_BADREPESCAPE = -57;
        public const int ERROR_REPMISSINGBRACE = -58;
        public const int ERROR_BADSUBSTITUTION = -59;
        public const int ERROR_BADSUBSPATTERN = -60;
        public const int ERROR_TOOMANYREPLACE = -61;
        public const int ERROR_BADSERIALIZEDDATA = -62;
        public const int ERROR_HEAPLIMIT = -63;
        public const int ERROR_CONVERT_SYNTAX = -64;
        public const int ERROR_INTERNAL_DUPMATCH = -65;
        public const int ERROR_DFA_UINVALID_UTF = -66;
        public const uint INFO_ALLOPTIONS = 0;
        public const uint INFO_ARGOPTIONS = 1;
        public const uint INFO_BACKREFMAX = 2;
        public const uint INFO_BSR = 3;
        public const uint INFO_CAPTURECOUNT = 4;
        public const uint INFO_FIRSTCODEUNIT = 5;
        public const uint INFO_FIRSTCODETYPE = 6;
        public const uint INFO_FIRSTBITMAP = 7;
        public const uint INFO_HASCRORLF = 8;
        public const uint INFO_JCHANGED = 9;
        public const uint INFO_JITSIZE = 10;
        public const uint INFO_LASTCODEUNIT = 11;
        public const uint INFO_LASTCODETYPE = 12;
        public const uint INFO_MATCHEMPTY = 13;
        public const uint INFO_MATCHLIMIT = 14;
        public const uint INFO_MAXLOOKBEHIND = 15;
        public const uint INFO_MINLENGTH = 16;
        public const uint INFO_NAMECOUNT = 17;
        public const uint INFO_NAMEENTRYSIZE = 18;
        public const uint INFO_NAMETABLE = 19;
        public const uint INFO_NEWLINE = 20;
        public const uint INFO_DEPTHLIMIT = 21;
        public const uint INFO_SIZE = 22;
        public const uint INFO_HASBACKSLASHC = 23;
        public const uint INFO_FRAMESIZE = 24;
        public const uint INFO_HEAPLIMIT = 25;
        public const uint INFO_EXTRAOPTIONS = 26;
        public const uint CONFIG_BSR = 0;
        public const uint CONFIG_JIT = 1;
        public const uint CONFIG_JITTARGET = 2;
        public const uint CONFIG_LINKSIZE = 3;
        public const uint CONFIG_MATCHLIMIT = 4;
        public const uint CONFIG_NEWLINE = 5;
        public const uint CONFIG_PARENSLIMIT = 6;
        public const uint CONFIG_DEPTHLIMIT = 7;
        public const uint CONFIG_UNICODE = 9;
        public const uint CONFIG_UNICODE_VERSION = 10;
        public const uint CONFIG_VERSION = 11;
        public const uint CONFIG_HEAPLIMIT = 12;
        public const uint CONFIG_NEVER_BACKSLASH_C = 13;
        public const uint CONFIG_COMPILED_WIDTHS = 14;
        public const uint CONFIG_TABLES_LENGTH = 15;
        public const uint CALLOUT_STARTMATCH = 0x00000001;
        public const uint CALLOUT_BACKTRACK = 0x00000002;
    }
}
