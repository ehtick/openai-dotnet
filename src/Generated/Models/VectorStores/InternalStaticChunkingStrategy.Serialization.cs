// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalStaticChunkingStrategy : IJsonModel<InternalStaticChunkingStrategy>
    {
        internal InternalStaticChunkingStrategy()
        {
        }

        void IJsonModel<InternalStaticChunkingStrategy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalStaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalStaticChunkingStrategy)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("max_chunk_size_tokens") != true)
            {
                writer.WritePropertyName("max_chunk_size_tokens"u8);
                writer.WriteNumberValue(MaxChunkSizeTokens);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("chunk_overlap_tokens") != true)
            {
                writer.WritePropertyName("chunk_overlap_tokens"u8);
                writer.WriteNumberValue(ChunkOverlapTokens);
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalStaticChunkingStrategy IJsonModel<InternalStaticChunkingStrategy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalStaticChunkingStrategy JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalStaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalStaticChunkingStrategy)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalStaticChunkingStrategy(document.RootElement, options);
        }

        internal static InternalStaticChunkingStrategy DeserializeInternalStaticChunkingStrategy(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxChunkSizeTokens = default;
            int chunkOverlapTokens = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("max_chunk_size_tokens"u8))
                {
                    maxChunkSizeTokens = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("chunk_overlap_tokens"u8))
                {
                    chunkOverlapTokens = prop.Value.GetInt32();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalStaticChunkingStrategy(maxChunkSizeTokens, chunkOverlapTokens, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalStaticChunkingStrategy>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalStaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalStaticChunkingStrategy)} does not support writing '{options.Format}' format.");
            }
        }

        InternalStaticChunkingStrategy IPersistableModel<InternalStaticChunkingStrategy>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalStaticChunkingStrategy PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalStaticChunkingStrategy>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalStaticChunkingStrategy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalStaticChunkingStrategy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalStaticChunkingStrategy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
