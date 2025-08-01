// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    [PersistableModelProxy(typeof(InternalUnknownResponseTextFormatConfiguration))]
    public partial class ResponseTextFormat : IJsonModel<ResponseTextFormat>
    {
        internal ResponseTextFormat()
        {
        }

        void IJsonModel<ResponseTextFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseTextFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseTextFormat)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(InternalType.ToString());
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

        ResponseTextFormat IJsonModel<ResponseTextFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ResponseTextFormat JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseTextFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseTextFormat)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseTextFormat(document.RootElement, options);
        }

        internal static ResponseTextFormat DeserializeResponseTextFormat(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "text":
                        return InternalResponsesTextFormatText.DeserializeInternalResponsesTextFormatText(element, options);
                    case "json_object":
                        return InternalResponsesTextFormatJsonObject.DeserializeInternalResponsesTextFormatJsonObject(element, options);
                    case "json_schema":
                        return InternalResponsesTextFormatJsonSchema.DeserializeInternalResponsesTextFormatJsonSchema(element, options);
                }
            }
            return InternalUnknownResponseTextFormatConfiguration.DeserializeInternalUnknownResponseTextFormatConfiguration(element, options);
        }

        BinaryData IPersistableModel<ResponseTextFormat>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseTextFormat>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ResponseTextFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ResponseTextFormat IPersistableModel<ResponseTextFormat>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ResponseTextFormat PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ResponseTextFormat>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeResponseTextFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResponseTextFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResponseTextFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
