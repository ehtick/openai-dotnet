// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalItemContentInputText : InternalEvalItemContent
    {
        public InternalEvalItemContentInputText(string text) : base(InternalEvalItemContentType.InputText)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
        }

        internal InternalEvalItemContentInputText(InternalEvalItemContentType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string text) : base(kind, additionalBinaryDataProperties)
        {
            Text = text;
        }

        public string Text { get; set; }
    }
}
