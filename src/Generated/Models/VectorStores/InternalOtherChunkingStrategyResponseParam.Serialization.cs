// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.VectorStores
{
    internal partial class InternalOtherChunkingStrategyResponseParam : IJsonModel<InternalOtherChunkingStrategyResponseParam>
    {
        void IJsonModel<InternalOtherChunkingStrategyResponseParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalOtherChunkingStrategyResponseParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOtherChunkingStrategyResponseParam)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalOtherChunkingStrategyResponseParam IJsonModel<InternalOtherChunkingStrategyResponseParam>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalOtherChunkingStrategyResponseParam)JsonModelCreateCore(ref reader, options);

        protected override InternalChunkingStrategyResponseParam JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalOtherChunkingStrategyResponseParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOtherChunkingStrategyResponseParam)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalOtherChunkingStrategyResponseParam(document.RootElement, options);
        }

        internal static InternalOtherChunkingStrategyResponseParam DeserializeInternalOtherChunkingStrategyResponseParam(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalChunkingStrategyResponseParamType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalChunkingStrategyResponseParamType(prop.Value.GetString());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalOtherChunkingStrategyResponseParam(kind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalOtherChunkingStrategyResponseParam>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalOtherChunkingStrategyResponseParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalOtherChunkingStrategyResponseParam)} does not support writing '{options.Format}' format.");
            }
        }

        InternalOtherChunkingStrategyResponseParam IPersistableModel<InternalOtherChunkingStrategyResponseParam>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalOtherChunkingStrategyResponseParam)PersistableModelCreateCore(data, options);

        protected override InternalChunkingStrategyResponseParam PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalOtherChunkingStrategyResponseParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalOtherChunkingStrategyResponseParam(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalOtherChunkingStrategyResponseParam)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalOtherChunkingStrategyResponseParam>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
