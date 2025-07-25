// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalDotNetRealtimeLogProbProperties
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalDotNetRealtimeLogProbProperties(string token, float logprob, IEnumerable<int> bytes)
        {
            Token = token;
            Logprob = logprob;
            Bytes = bytes.ToList();
        }

        internal InternalDotNetRealtimeLogProbProperties(string token, float logprob, IList<int> bytes, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Token = token;
            Logprob = logprob;
            Bytes = bytes ?? new ChangeTrackingList<int>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Token { get; }

        public float Logprob { get; }

        public IList<int> Bytes { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
