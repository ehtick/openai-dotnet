// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Realtime
{
    [Experimental("OPENAI002")]
    public partial class ConversationTool
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected ConversationTool(ConversationToolKind kind)
        {
            Kind = kind;
        }

        internal ConversationTool(ConversationToolKind kind, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Kind = kind;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
