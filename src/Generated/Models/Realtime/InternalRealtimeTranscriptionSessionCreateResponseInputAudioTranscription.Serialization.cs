// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription : IJsonModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>
    {
        void IJsonModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Model) && _additionalBinaryDataProperties?.ContainsKey("model") != true)
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model.Value.ToString());
            }
            if (Optional.IsDefined(Language) && _additionalBinaryDataProperties?.ContainsKey("language") != true)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Prompt) && _additionalBinaryDataProperties?.ContainsKey("prompt") != true)
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
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

        InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription IJsonModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription(document.RootElement, options);
        }

        internal static InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription DeserializeInternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? model = default;
            string language = default;
            string prompt = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("model"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    model = new InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("language"u8))
                {
                    language = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("prompt"u8))
                {
                    prompt = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription(model, language, prompt, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeTranscriptionSessionCreateResponseInputAudioTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
