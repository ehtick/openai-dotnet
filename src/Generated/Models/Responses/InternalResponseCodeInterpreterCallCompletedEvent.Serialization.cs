// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponseCodeInterpreterCallCompletedEvent : IJsonModel<InternalResponseCodeInterpreterCallCompletedEvent>
    {
        internal InternalResponseCodeInterpreterCallCompletedEvent() : this(InternalResponseStreamEventType.ResponseCodeInterpreterCallCompleted, default, null, default, null)
        {
        }

        void IJsonModel<InternalResponseCodeInterpreterCallCompletedEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseCodeInterpreterCallCompletedEvent)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("code_interpreter_call") != true)
            {
                writer.WritePropertyName("code_interpreter_call"u8);
                writer.WriteObjectValue(CodeInterpreterCall, options);
            }
        }

        InternalResponseCodeInterpreterCallCompletedEvent IJsonModel<InternalResponseCodeInterpreterCallCompletedEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponseCodeInterpreterCallCompletedEvent)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseCodeInterpreterCallCompletedEvent)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponseCodeInterpreterCallCompletedEvent(document.RootElement, options);
        }

        internal static InternalResponseCodeInterpreterCallCompletedEvent DeserializeInternalResponseCodeInterpreterCallCompletedEvent(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponseStreamEventType kind = default;
            int sequenceNumber = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            int outputIndex = default;
            InternalCodeInterpreterToolCallItemResource codeInterpreterCall = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalResponseStreamEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("sequence_number"u8))
                {
                    sequenceNumber = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("output_index"u8))
                {
                    outputIndex = prop.Value.GetInt32();
                    continue;
                }
                if (prop.NameEquals("code_interpreter_call"u8))
                {
                    codeInterpreterCall = InternalCodeInterpreterToolCallItemResource.DeserializeInternalCodeInterpreterToolCallItemResource(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponseCodeInterpreterCallCompletedEvent(kind, sequenceNumber, additionalBinaryDataProperties, outputIndex, codeInterpreterCall);
        }

        BinaryData IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalResponseCodeInterpreterCallCompletedEvent)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponseCodeInterpreterCallCompletedEvent IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponseCodeInterpreterCallCompletedEvent)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponseCodeInterpreterCallCompletedEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponseCodeInterpreterCallCompletedEvent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponseCodeInterpreterCallCompletedEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
