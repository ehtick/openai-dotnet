// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobRequestMethodDpo : IJsonModel<InternalFineTuningJobRequestMethodDpo>
    {
        void IJsonModel<InternalFineTuningJobRequestMethodDpo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobRequestMethodDpo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningJobRequestMethodDpo)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Hyperparameters) && _additionalBinaryDataProperties?.ContainsKey("hyperparameters") != true)
            {
                writer.WritePropertyName("hyperparameters"u8);
                writer.WriteObjectValue(Hyperparameters, options);
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

        InternalFineTuningJobRequestMethodDpo IJsonModel<InternalFineTuningJobRequestMethodDpo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalFineTuningJobRequestMethodDpo JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobRequestMethodDpo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFineTuningJobRequestMethodDpo)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFineTuningJobRequestMethodDpo(document.RootElement, options);
        }

        internal static InternalFineTuningJobRequestMethodDpo DeserializeInternalFineTuningJobRequestMethodDpo(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HyperparametersForDPO hyperparameters = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("hyperparameters"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hyperparameters = HyperparametersForDPO.DeserializeHyperparametersForDPO(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalFineTuningJobRequestMethodDpo(hyperparameters, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalFineTuningJobRequestMethodDpo>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobRequestMethodDpo>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningJobRequestMethodDpo)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFineTuningJobRequestMethodDpo IPersistableModel<InternalFineTuningJobRequestMethodDpo>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalFineTuningJobRequestMethodDpo PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFineTuningJobRequestMethodDpo>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalFineTuningJobRequestMethodDpo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFineTuningJobRequestMethodDpo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFineTuningJobRequestMethodDpo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
