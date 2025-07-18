// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    public partial class InputAudioSpeechFinishedUpdate : IJsonModel<InputAudioSpeechFinishedUpdate>
    {
        internal InputAudioSpeechFinishedUpdate() : this(RealtimeUpdateKind.InputSpeechStopped, null, null, null, default)
        {
        }

        void IJsonModel<InputAudioSpeechFinishedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InputAudioSpeechFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InputAudioSpeechFinishedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("audio_end_ms") != true)
            {
                writer.WritePropertyName("audio_end_ms"u8);
                writer.WriteNumberValue(_audioEndMs);
            }
        }

        InputAudioSpeechFinishedUpdate IJsonModel<InputAudioSpeechFinishedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InputAudioSpeechFinishedUpdate)JsonModelCreateCore(ref reader, options);

        protected override RealtimeUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InputAudioSpeechFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InputAudioSpeechFinishedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInputAudioSpeechFinishedUpdate(document.RootElement, options);
        }

        internal static InputAudioSpeechFinishedUpdate DeserializeInputAudioSpeechFinishedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RealtimeUpdateKind kind = default;
            string eventId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            string itemId = default;
            int audioEndMs = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToRealtimeUpdateKind();
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("item_id"u8))
                {
                    itemId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("audio_end_ms"u8))
                {
                    audioEndMs = prop.Value.GetInt32();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InputAudioSpeechFinishedUpdate(kind, eventId, additionalBinaryDataProperties, itemId, audioEndMs);
        }

        BinaryData IPersistableModel<InputAudioSpeechFinishedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InputAudioSpeechFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InputAudioSpeechFinishedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        InputAudioSpeechFinishedUpdate IPersistableModel<InputAudioSpeechFinishedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (InputAudioSpeechFinishedUpdate)PersistableModelCreateCore(data, options);

        protected override RealtimeUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InputAudioSpeechFinishedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInputAudioSpeechFinishedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InputAudioSpeechFinishedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InputAudioSpeechFinishedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
