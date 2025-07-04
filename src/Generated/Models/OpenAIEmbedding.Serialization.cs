// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Embeddings
{
    public partial class OpenAIEmbedding : IJsonModel<OpenAIEmbedding>
    {
        internal OpenAIEmbedding()
        {
        }

        void IJsonModel<OpenAIEmbedding>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        [Experimental("OPENAI001")]
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIEmbedding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIEmbedding)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("index") != true)
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("embedding") != true)
            {
                writer.WritePropertyName("embedding"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(EmbeddingProperty);
#else
                using (JsonDocument document = JsonDocument.Parse(EmbeddingProperty))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (_additionalBinaryDataProperties?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object);
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

        OpenAIEmbedding IJsonModel<OpenAIEmbedding>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        [Experimental("OPENAI001")]
        protected virtual OpenAIEmbedding JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIEmbedding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIEmbedding)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAIEmbedding(document.RootElement, options);
        }

        internal static OpenAIEmbedding DeserializeOpenAIEmbedding(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int index = default;
            BinaryData embeddingProperty = default;
            string @object = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("index"u8))
                {
                    index = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("embedding"u8))
                {
                    embeddingProperty = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("object"u8))
                {
                    @object = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new OpenAIEmbedding(index, embeddingProperty, @object, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<OpenAIEmbedding>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        [Experimental("OPENAI001")]
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIEmbedding>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OpenAIEmbedding)} does not support writing '{options.Format}' format.");
            }
        }

        OpenAIEmbedding IPersistableModel<OpenAIEmbedding>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        [Experimental("OPENAI001")]
        protected virtual OpenAIEmbedding PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<OpenAIEmbedding>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeOpenAIEmbedding(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAIEmbedding)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAIEmbedding>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
