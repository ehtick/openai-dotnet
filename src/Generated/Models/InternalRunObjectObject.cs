// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunObjectObject : IEquatable<InternalRunObjectObject>
    {
        private readonly string _value;
        private const string ThreadRunValue = "thread.run";

        public InternalRunObjectObject(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalRunObjectObject ThreadRun { get; } = new InternalRunObjectObject(ThreadRunValue);

        public static bool operator ==(InternalRunObjectObject left, InternalRunObjectObject right) => left.Equals(right);

        public static bool operator !=(InternalRunObjectObject left, InternalRunObjectObject right) => !left.Equals(right);

        public static implicit operator InternalRunObjectObject(string value) => new InternalRunObjectObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunObjectObject other && Equals(other);

        public bool Equals(InternalRunObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
