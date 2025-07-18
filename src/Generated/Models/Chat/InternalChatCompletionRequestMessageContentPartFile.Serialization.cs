// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartFile : IJsonModel<InternalChatCompletionRequestMessageContentPartFile>
    {
        internal InternalChatCompletionRequestMessageContentPartFile()
        {
        }

        void IJsonModel<InternalChatCompletionRequestMessageContentPartFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartFile)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("file") != true)
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue(File, options);
            }
        }

        InternalChatCompletionRequestMessageContentPartFile IJsonModel<InternalChatCompletionRequestMessageContentPartFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartFile)JsonModelCreateCore(ref reader, options);

        protected override ChatMessageContentPart JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartFile)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionRequestMessageContentPartFile(document.RootElement, options);
        }

        internal static InternalChatCompletionRequestMessageContentPartFile DeserializeInternalChatCompletionRequestMessageContentPartFile(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalChatCompletionRequestMessageContentPartFileFile @file = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file"u8))
                {
                    @file = InternalChatCompletionRequestMessageContentPartFileFile.DeserializeInternalChatCompletionRequestMessageContentPartFileFile(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatCompletionRequestMessageContentPartFile(additionalBinaryDataProperties, @file);
        }

        BinaryData IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartFile)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionRequestMessageContentPartFile IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalChatCompletionRequestMessageContentPartFile)PersistableModelCreateCore(data, options);

        protected override ChatMessageContentPart PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatCompletionRequestMessageContentPartFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionRequestMessageContentPartFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionRequestMessageContentPartFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
