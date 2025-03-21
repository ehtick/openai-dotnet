// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class FineTuningJobError
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal FineTuningJobError(string code, string message, string @param)
        {
            Code = code;
            Message = message;
            Param = @param;
        }

        internal FineTuningJobError(string code, string message, string @param, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Code = code;
            Message = message;
            Param = @param;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Code { get; }

        public string Message { get; }

        public string Param { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
