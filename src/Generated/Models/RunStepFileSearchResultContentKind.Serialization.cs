// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Assistants
{
    internal static partial class RunStepFileSearchResultContentKindExtensions
    {
        public static string ToSerialString(this RunStepFileSearchResultContentKind value) => value switch
        {
            RunStepFileSearchResultContentKind.Text => "text",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunStepFileSearchResultContentKind value.")
        };

        public static RunStepFileSearchResultContentKind ToRunStepFileSearchResultContentKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "text"))
            {
                return RunStepFileSearchResultContentKind.Text;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunStepFileSearchResultContentKind value.");
        }
    }
}
