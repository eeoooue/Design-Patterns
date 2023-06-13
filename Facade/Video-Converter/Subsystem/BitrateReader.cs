using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Converter.Subsystem.Codecs;

namespace Video_Converter.Subsystem
{
    internal class BitrateReader
    {
        public void Read(string filename, Codec sourceCodec) { }

        public VideoFile Convert(string filename, Codec destinationCodec)
        {
            string extension;
            if (destinationCodec is MPEG4CompressionCodec)
            {
                extension = "mp4";
            }
            else if (destinationCodec is OggCompressionCodec)
            {
                extension = "ogg";
            }
            else
            {
                throw new NotImplementedException();
            }

            return new VideoFile($"{filename}_converted.{extension}");
        }
    }
}
