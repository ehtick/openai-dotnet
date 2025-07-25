// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalUnknownChunkingStrategyRequestParamProxy : IJsonModel<InternalChunkingStrategyRequestParam>
    {
        internal InternalUnknownChunkingStrategyRequestParamProxy() : this(default, null)
        {
        }

        void IJsonModel<InternalChunkingStrategyRequestParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChunkingStrategyRequestParam)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalChunkingStrategyRequestParam IJsonModel<InternalChunkingStrategyRequestParam>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected override InternalChunkingStrategyRequestParam JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChunkingStrategyRequestParam)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChunkingStrategyRequestParam(document.RootElement, options);
        }

        internal static InternalUnknownChunkingStrategyRequestParamProxy DeserializeInternalUnknownChunkingStrategyRequestParamProxy(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalChunkingStrategyRequestParamType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalChunkingStrategyRequestParamType(prop.Value.GetString());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalUnknownChunkingStrategyRequestParamProxy(kind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalChunkingStrategyRequestParam>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalChunkingStrategyRequestParam)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChunkingStrategyRequestParam IPersistableModel<InternalChunkingStrategyRequestParam>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected override InternalChunkingStrategyRequestParam PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChunkingStrategyRequestParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChunkingStrategyRequestParam(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChunkingStrategyRequestParam)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChunkingStrategyRequestParam>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
