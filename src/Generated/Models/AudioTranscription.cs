// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Audio
{
    public partial class AudioTranscription
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal AudioTranscription(string language, string text, TimeSpan? duration)
        {
            Language = language;
            Text = text;
            Words = new ChangeTrackingList<TranscribedWord>();
            Segments = new ChangeTrackingList<TranscribedSegment>();
            Duration = duration;
            TranscriptionTokenLogProbabilities = new ChangeTrackingList<AudioTokenLogProbabilityDetails>();
        }

        internal AudioTranscription(string language, string text, IReadOnlyList<TranscribedWord> words, IReadOnlyList<TranscribedSegment> segments, string task, TimeSpan? duration, IReadOnlyList<AudioTokenLogProbabilityDetails> transcriptionTokenLogProbabilities, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Language = language;
            Text = text;
            Words = words ?? new ChangeTrackingList<TranscribedWord>();
            Segments = segments ?? new ChangeTrackingList<TranscribedSegment>();
            Task = task;
            Duration = duration;
            TranscriptionTokenLogProbabilities = transcriptionTokenLogProbabilities ?? new ChangeTrackingList<AudioTokenLogProbabilityDetails>();
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Language { get; }

        public string Text { get; }

        public IReadOnlyList<TranscribedWord> Words { get; }

        public IReadOnlyList<TranscribedSegment> Segments { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
