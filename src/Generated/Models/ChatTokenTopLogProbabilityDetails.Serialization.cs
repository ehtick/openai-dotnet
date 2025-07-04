// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    public partial class ChatTokenTopLogProbabilityDetails : IJsonModel<ChatTokenTopLogProbabilityDetails>
    {
        internal ChatTokenTopLogProbabilityDetails()
        {
        }

        void IJsonModel<ChatTokenTopLogProbabilityDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        [Experimental("OPENAI001")]
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenTopLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenTopLogProbabilityDetails)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("token") != true)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("logprob") != true)
            {
                writer.WritePropertyName("logprob"u8);
                writer.WriteNumberValue(LogProbability);
            }
            if (_additionalBinaryDataProperties?.ContainsKey("bytes") != true)
            {
                if (Optional.IsDefined(Utf8Bytes))
                {
                    writer.WritePropertyName("bytes"u8);
                    writer.WriteStartArray();
                    foreach (byte item in Utf8Bytes.Value.Span)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("bytes"u8);
                }
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

        ChatTokenTopLogProbabilityDetails IJsonModel<ChatTokenTopLogProbabilityDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        [Experimental("OPENAI001")]
        protected virtual ChatTokenTopLogProbabilityDetails JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenTopLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatTokenTopLogProbabilityDetails)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatTokenTopLogProbabilityDetails(document.RootElement, options);
        }

        internal static ChatTokenTopLogProbabilityDetails DeserializeChatTokenTopLogProbabilityDetails(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            float logProbability = default;
            ReadOnlyMemory<byte>? utf8Bytes = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("token"u8))
                {
                    token = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("logprob"u8))
                {
                    logProbability = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("bytes"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    int index = 0;
                    byte[] array = new byte[prop.Value.GetArrayLength()];
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array[index] = item.GetByte();
                        index++;
                    }
                    utf8Bytes = new ReadOnlyMemory<byte>(array);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ChatTokenTopLogProbabilityDetails(token, logProbability, utf8Bytes, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ChatTokenTopLogProbabilityDetails>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        [Experimental("OPENAI001")]
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenTopLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ChatTokenTopLogProbabilityDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ChatTokenTopLogProbabilityDetails IPersistableModel<ChatTokenTopLogProbabilityDetails>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        [Experimental("OPENAI001")]
        protected virtual ChatTokenTopLogProbabilityDetails PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ChatTokenTopLogProbabilityDetails>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeChatTokenTopLogProbabilityDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatTokenTopLogProbabilityDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatTokenTopLogProbabilityDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
