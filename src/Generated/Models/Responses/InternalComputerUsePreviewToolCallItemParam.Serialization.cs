// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalComputerUsePreviewToolCallItemParam : IJsonModel<InternalComputerUsePreviewToolCallItemParam>
    {
        internal InternalComputerUsePreviewToolCallItemParam() : this(InternalItemType.ComputerCall, null, null, null, null)
        {
        }

        void IJsonModel<InternalComputerUsePreviewToolCallItemParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalComputerUsePreviewToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalComputerUsePreviewToolCallItemParam)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("action") != true)
            {
                writer.WritePropertyName("action"u8);
                writer.WriteObjectValue(Action, options);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("pending_safety_checks") != true)
            {
                writer.WritePropertyName("pending_safety_checks"u8);
                writer.WriteStartArray();
                foreach (ComputerCallSafetyCheck item in PendingSafetyChecks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        InternalComputerUsePreviewToolCallItemParam IJsonModel<InternalComputerUsePreviewToolCallItemParam>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalComputerUsePreviewToolCallItemParam)JsonModelCreateCore(ref reader, options);

        protected override InternalItemParam JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalComputerUsePreviewToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalComputerUsePreviewToolCallItemParam)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalComputerUsePreviewToolCallItemParam(document.RootElement, options);
        }

        internal static InternalComputerUsePreviewToolCallItemParam DeserializeInternalComputerUsePreviewToolCallItemParam(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalItemType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string callId = default;
            ComputerCallAction action = default;
            IList<ComputerCallSafetyCheck> pendingSafetyChecks = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("call_id"u8))
                {
                    callId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("action"u8))
                {
                    action = ComputerCallAction.DeserializeComputerCallAction(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("pending_safety_checks"u8))
                {
                    List<ComputerCallSafetyCheck> array = new List<ComputerCallSafetyCheck>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ComputerCallSafetyCheck.DeserializeComputerCallSafetyCheck(item, options));
                    }
                    pendingSafetyChecks = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalComputerUsePreviewToolCallItemParam(kind, additionalBinaryDataProperties, callId, action, pendingSafetyChecks);
        }

        BinaryData IPersistableModel<InternalComputerUsePreviewToolCallItemParam>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalComputerUsePreviewToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalComputerUsePreviewToolCallItemParam)} does not support writing '{options.Format}' format.");
            }
        }

        InternalComputerUsePreviewToolCallItemParam IPersistableModel<InternalComputerUsePreviewToolCallItemParam>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalComputerUsePreviewToolCallItemParam)PersistableModelCreateCore(data, options);

        protected override InternalItemParam PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalComputerUsePreviewToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalComputerUsePreviewToolCallItemParam(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalComputerUsePreviewToolCallItemParam)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalComputerUsePreviewToolCallItemParam>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
