// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalCreateThreadAndRunRequestToolChoice : IEquatable<InternalCreateThreadAndRunRequestToolChoice>
    {
        private readonly string _value;
        private const string NoneValue = "none";
        private const string AutoValue = "auto";
        private const string RequiredValue = "required";

        public InternalCreateThreadAndRunRequestToolChoice(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalCreateThreadAndRunRequestToolChoice None { get; } = new InternalCreateThreadAndRunRequestToolChoice(NoneValue);

        internal static InternalCreateThreadAndRunRequestToolChoice Auto { get; } = new InternalCreateThreadAndRunRequestToolChoice(AutoValue);

        internal static InternalCreateThreadAndRunRequestToolChoice Required { get; } = new InternalCreateThreadAndRunRequestToolChoice(RequiredValue);

        public static bool operator ==(InternalCreateThreadAndRunRequestToolChoice left, InternalCreateThreadAndRunRequestToolChoice right) => left.Equals(right);

        public static bool operator !=(InternalCreateThreadAndRunRequestToolChoice left, InternalCreateThreadAndRunRequestToolChoice right) => !left.Equals(right);

        public static implicit operator InternalCreateThreadAndRunRequestToolChoice(string value) => new InternalCreateThreadAndRunRequestToolChoice(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateThreadAndRunRequestToolChoice other && Equals(other);

        public bool Equals(InternalCreateThreadAndRunRequestToolChoice other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
