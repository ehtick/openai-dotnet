// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Containers
{
    internal partial class InternalContainerListResource
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalContainerListResource(IEnumerable<InternalContainerResource> data, string firstId, string lastId, bool hasMore)
        {
            Data = data.ToList();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalContainerListResource(string @object, IList<InternalContainerResource> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Object = @object;
            Data = data ?? new ChangeTrackingList<InternalContainerResource>();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Object { get; } = "list";

        internal IList<InternalContainerResource> Data { get; }

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
