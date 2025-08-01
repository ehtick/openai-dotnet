// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses
{
    [Experimental("OPENAI001")]
    public partial class StreamingResponseWebSearchCallInProgressUpdate : StreamingResponseUpdate
    {
        internal StreamingResponseWebSearchCallInProgressUpdate(int sequenceNumber, int outputIndex, string itemId) : base(InternalResponseStreamEventType.ResponseWebSearchCallInProgress, sequenceNumber)
        {
            OutputIndex = outputIndex;
            ItemId = itemId;
        }

        internal StreamingResponseWebSearchCallInProgressUpdate(InternalResponseStreamEventType kind, int sequenceNumber, IDictionary<string, BinaryData> additionalBinaryDataProperties, int outputIndex, string itemId) : base(kind, sequenceNumber, additionalBinaryDataProperties)
        {
            OutputIndex = outputIndex;
            ItemId = itemId;
        }

        public int OutputIndex { get; }

        public string ItemId { get; }
    }
}
