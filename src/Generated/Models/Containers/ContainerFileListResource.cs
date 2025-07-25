// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using OpenAI;

namespace OpenAI.Containers
{
    [Experimental("OPENAI001")]
    public partial class ContainerFileListResource
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ContainerFileListResource(IEnumerable<ContainerFileResource> data, string firstId, string lastId, bool hasMore)
        {
            Data = data.ToList();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal ContainerFileListResource(string @object, IList<ContainerFileResource> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Object = @object;
            Data = data ?? new ChangeTrackingList<ContainerFileResource>();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Object { get; } = "list";

        public IList<ContainerFileResource> Data { get; }

        public string FirstId { get; }

        public string LastId { get; }

        public bool HasMore { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
