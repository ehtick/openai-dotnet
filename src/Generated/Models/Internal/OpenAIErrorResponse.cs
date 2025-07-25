// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal
{
    internal partial class OpenAIErrorResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal OpenAIErrorResponse(OpenAIError error)
        {
            Error = error;
        }

        internal OpenAIErrorResponse(OpenAIError error, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Error = error;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal OpenAIError Error { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
