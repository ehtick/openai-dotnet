// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalAssistantSupportedModels : IEquatable<InternalAssistantSupportedModels>
    {
        private readonly string _value;
        private const string Gpt41Value = "gpt-4.1";
        private const string Gpt41MiniValue = "gpt-4.1-mini";
        private const string Gpt41NanoValue = "gpt-4.1-nano";
        private const string Gpt4120250414Value = "gpt-4.1-2025-04-14";
        private const string Gpt41Mini20250414Value = "gpt-4.1-mini-2025-04-14";
        private const string Gpt41Nano20250414Value = "gpt-4.1-nano-2025-04-14";
        private const string O3MiniValue = "o3-mini";
        private const string O3Mini20250131Value = "o3-mini-2025-01-31";
        private const string O1Value = "o1";
        private const string O120241217Value = "o1-2024-12-17";
        private const string Gpt4oValue = "gpt-4o";
        private const string Gpt4o20241120Value = "gpt-4o-2024-11-20";
        private const string Gpt4o20240806Value = "gpt-4o-2024-08-06";
        private const string Gpt4o20240513Value = "gpt-4o-2024-05-13";
        private const string Gpt4oMiniValue = "gpt-4o-mini";
        private const string Gpt4oMini20240718Value = "gpt-4o-mini-2024-07-18";
        private const string Gpt45PreviewValue = "gpt-4.5-preview";
        private const string Gpt45Preview20250227Value = "gpt-4.5-preview-2025-02-27";
        private const string Gpt4TurboValue = "gpt-4-turbo";
        private const string Gpt4Turbo20240409Value = "gpt-4-turbo-2024-04-09";
        private const string Gpt40125PreviewValue = "gpt-4-0125-preview";
        private const string Gpt4TurboPreviewValue = "gpt-4-turbo-preview";
        private const string Gpt41106PreviewValue = "gpt-4-1106-preview";
        private const string Gpt4VisionPreviewValue = "gpt-4-vision-preview";
        private const string Gpt4Value = "gpt-4";
        private const string Gpt40314Value = "gpt-4-0314";
        private const string Gpt40613Value = "gpt-4-0613";
        private const string Gpt432kValue = "gpt-4-32k";
        private const string Gpt432k0314Value = "gpt-4-32k-0314";
        private const string Gpt432k0613Value = "gpt-4-32k-0613";
        private const string Gpt35TurboValue = "gpt-3.5-turbo";
        private const string Gpt35Turbo16kValue = "gpt-3.5-turbo-16k";
        private const string Gpt35Turbo0613Value = "gpt-3.5-turbo-0613";
        private const string Gpt35Turbo1106Value = "gpt-3.5-turbo-1106";
        private const string Gpt35Turbo0125Value = "gpt-3.5-turbo-0125";
        private const string Gpt35Turbo16k0613Value = "gpt-3.5-turbo-16k-0613";

        public InternalAssistantSupportedModels(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalAssistantSupportedModels Gpt41 { get; } = new InternalAssistantSupportedModels(Gpt41Value);

        internal static InternalAssistantSupportedModels Gpt41Mini { get; } = new InternalAssistantSupportedModels(Gpt41MiniValue);

        internal static InternalAssistantSupportedModels Gpt41Nano { get; } = new InternalAssistantSupportedModels(Gpt41NanoValue);

        internal static InternalAssistantSupportedModels Gpt4120250414 { get; } = new InternalAssistantSupportedModels(Gpt4120250414Value);

        internal static InternalAssistantSupportedModels Gpt41Mini20250414 { get; } = new InternalAssistantSupportedModels(Gpt41Mini20250414Value);

        internal static InternalAssistantSupportedModels Gpt41Nano20250414 { get; } = new InternalAssistantSupportedModels(Gpt41Nano20250414Value);

        internal static InternalAssistantSupportedModels O3Mini { get; } = new InternalAssistantSupportedModels(O3MiniValue);

        internal static InternalAssistantSupportedModels O3Mini20250131 { get; } = new InternalAssistantSupportedModels(O3Mini20250131Value);

        internal static InternalAssistantSupportedModels O1 { get; } = new InternalAssistantSupportedModels(O1Value);

        internal static InternalAssistantSupportedModels O120241217 { get; } = new InternalAssistantSupportedModels(O120241217Value);

        internal static InternalAssistantSupportedModels Gpt4o { get; } = new InternalAssistantSupportedModels(Gpt4oValue);

        internal static InternalAssistantSupportedModels Gpt4o20241120 { get; } = new InternalAssistantSupportedModels(Gpt4o20241120Value);

        internal static InternalAssistantSupportedModels Gpt4o20240806 { get; } = new InternalAssistantSupportedModels(Gpt4o20240806Value);

        internal static InternalAssistantSupportedModels Gpt4o20240513 { get; } = new InternalAssistantSupportedModels(Gpt4o20240513Value);

        internal static InternalAssistantSupportedModels Gpt4oMini { get; } = new InternalAssistantSupportedModels(Gpt4oMiniValue);

        internal static InternalAssistantSupportedModels Gpt4oMini20240718 { get; } = new InternalAssistantSupportedModels(Gpt4oMini20240718Value);

        internal static InternalAssistantSupportedModels Gpt45Preview { get; } = new InternalAssistantSupportedModels(Gpt45PreviewValue);

        internal static InternalAssistantSupportedModels Gpt45Preview20250227 { get; } = new InternalAssistantSupportedModels(Gpt45Preview20250227Value);

        internal static InternalAssistantSupportedModels Gpt4Turbo { get; } = new InternalAssistantSupportedModels(Gpt4TurboValue);

        internal static InternalAssistantSupportedModels Gpt4Turbo20240409 { get; } = new InternalAssistantSupportedModels(Gpt4Turbo20240409Value);

        internal static InternalAssistantSupportedModels Gpt40125Preview { get; } = new InternalAssistantSupportedModels(Gpt40125PreviewValue);

        internal static InternalAssistantSupportedModels Gpt4TurboPreview { get; } = new InternalAssistantSupportedModels(Gpt4TurboPreviewValue);

        internal static InternalAssistantSupportedModels Gpt41106Preview { get; } = new InternalAssistantSupportedModels(Gpt41106PreviewValue);

        internal static InternalAssistantSupportedModels Gpt4VisionPreview { get; } = new InternalAssistantSupportedModels(Gpt4VisionPreviewValue);

        internal static InternalAssistantSupportedModels Gpt4 { get; } = new InternalAssistantSupportedModels(Gpt4Value);

        internal static InternalAssistantSupportedModels Gpt40314 { get; } = new InternalAssistantSupportedModels(Gpt40314Value);

        internal static InternalAssistantSupportedModels Gpt40613 { get; } = new InternalAssistantSupportedModels(Gpt40613Value);

        internal static InternalAssistantSupportedModels Gpt432k { get; } = new InternalAssistantSupportedModels(Gpt432kValue);

        internal static InternalAssistantSupportedModels Gpt432k0314 { get; } = new InternalAssistantSupportedModels(Gpt432k0314Value);

        internal static InternalAssistantSupportedModels Gpt432k0613 { get; } = new InternalAssistantSupportedModels(Gpt432k0613Value);

        internal static InternalAssistantSupportedModels Gpt35Turbo { get; } = new InternalAssistantSupportedModels(Gpt35TurboValue);

        internal static InternalAssistantSupportedModels Gpt35Turbo16k { get; } = new InternalAssistantSupportedModels(Gpt35Turbo16kValue);

        internal static InternalAssistantSupportedModels Gpt35Turbo0613 { get; } = new InternalAssistantSupportedModels(Gpt35Turbo0613Value);

        internal static InternalAssistantSupportedModels Gpt35Turbo1106 { get; } = new InternalAssistantSupportedModels(Gpt35Turbo1106Value);

        internal static InternalAssistantSupportedModels Gpt35Turbo0125 { get; } = new InternalAssistantSupportedModels(Gpt35Turbo0125Value);

        internal static InternalAssistantSupportedModels Gpt35Turbo16k0613 { get; } = new InternalAssistantSupportedModels(Gpt35Turbo16k0613Value);

        public static bool operator ==(InternalAssistantSupportedModels left, InternalAssistantSupportedModels right) => left.Equals(right);

        public static bool operator !=(InternalAssistantSupportedModels left, InternalAssistantSupportedModels right) => !left.Equals(right);

        public static implicit operator InternalAssistantSupportedModels(string value) => new InternalAssistantSupportedModels(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalAssistantSupportedModels other && Equals(other);

        public bool Equals(InternalAssistantSupportedModels other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
