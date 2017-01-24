﻿using System.IO;

namespace Texart
{
    public interface ITextDataRenderer
    {
        /// <summary>
        /// Write some text data to an output stream.
        /// </summary>
        /// <param name="textData">The source text data</param>
        /// <param name="outputStream">The stream to write to</param>
        void Render(ITextData textData, Stream outputStream);
    }
}