// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using OpenAI;

namespace OpenAI.Responses
{
    [Experimental("OPENAI001")]
    public partial class FileSearchCallResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public FileSearchCallResult() : this(null, null, null, default, null, null)
        {
        }

        internal FileSearchCallResult(string fileId, string text, string filename, float? score, IReadOnlyDictionary<string, BinaryData> attributes, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            FileId = fileId;
            Text = text;
            Filename = filename;
            Score = score;
            Attributes = attributes ?? new ChangeTrackingDictionary<string, BinaryData>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string FileId { get; set; }

        public string Text { get; set; }

        public string Filename { get; set; }

        public float? Score { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
