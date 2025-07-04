// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalLocalShellToolCallItemResourceStatus : IEquatable<InternalLocalShellToolCallItemResourceStatus>
    {
        private readonly string _value;
        private const string InProgressValue = "in_progress";
        private const string CompletedValue = "completed";
        private const string IncompleteValue = "incomplete";

        public InternalLocalShellToolCallItemResourceStatus(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        internal static InternalLocalShellToolCallItemResourceStatus InProgress { get; } = new InternalLocalShellToolCallItemResourceStatus(InProgressValue);

        internal static InternalLocalShellToolCallItemResourceStatus Completed { get; } = new InternalLocalShellToolCallItemResourceStatus(CompletedValue);

        internal static InternalLocalShellToolCallItemResourceStatus Incomplete { get; } = new InternalLocalShellToolCallItemResourceStatus(IncompleteValue);

        public static bool operator ==(InternalLocalShellToolCallItemResourceStatus left, InternalLocalShellToolCallItemResourceStatus right) => left.Equals(right);

        public static bool operator !=(InternalLocalShellToolCallItemResourceStatus left, InternalLocalShellToolCallItemResourceStatus right) => !left.Equals(right);

        public static implicit operator InternalLocalShellToolCallItemResourceStatus(string value) => new InternalLocalShellToolCallItemResourceStatus(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalLocalShellToolCallItemResourceStatus other && Equals(other);

        public bool Equals(InternalLocalShellToolCallItemResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
