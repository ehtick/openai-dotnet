// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalComputerToolCallOutputItemOutputComputerScreenshot : ComputerOutput
    {
        public InternalComputerToolCallOutputItemOutputComputerScreenshot() : this(InternalComputerUsePreviewToolCallOutputOutputType.Screenshot, null, null, null)
        {
        }

        internal InternalComputerToolCallOutputItemOutputComputerScreenshot(InternalComputerUsePreviewToolCallOutputOutputType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string imageUrl, string fileId) : base(kind, additionalBinaryDataProperties)
        {
            ImageUrl = imageUrl;
            FileId = fileId;
        }

        public string ImageUrl { get; set; }

        public string FileId { get; set; }
    }
}
