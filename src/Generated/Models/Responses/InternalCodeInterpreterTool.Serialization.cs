// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalCodeInterpreterTool : IJsonModel<InternalCodeInterpreterTool>
    {
        internal InternalCodeInterpreterTool() : this(InternalToolType.CodeInterpreter, null, null)
        {
        }

        void IJsonModel<InternalCodeInterpreterTool>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterTool)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("container") != true)
            {
                writer.WritePropertyName("container"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(Container);
#else
                using (JsonDocument document = JsonDocument.Parse(Container))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }

        InternalCodeInterpreterTool IJsonModel<InternalCodeInterpreterTool>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalCodeInterpreterTool)JsonModelCreateCore(ref reader, options);

        protected override ResponseTool JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTool>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCodeInterpreterTool)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCodeInterpreterTool(document.RootElement, options);
        }

        internal static InternalCodeInterpreterTool DeserializeInternalCodeInterpreterTool(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalToolType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            BinaryData container = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalToolType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("container"u8))
                {
                    container = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalCodeInterpreterTool(kind, additionalBinaryDataProperties, container);
        }

        BinaryData IPersistableModel<InternalCodeInterpreterTool>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTool>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterTool)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCodeInterpreterTool IPersistableModel<InternalCodeInterpreterTool>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalCodeInterpreterTool)PersistableModelCreateCore(data, options);

        protected override ResponseTool PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalCodeInterpreterTool>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalCodeInterpreterTool(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCodeInterpreterTool)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCodeInterpreterTool>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
