using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Converter.Subsystem;
using Video_Converter.Subsystem.Codecs;

namespace Video_Converter
{
    internal class VideoConverter
    {
        public GeneralFile Convert(string filename, string desiredFormat)
        {

            VideoFile file = new VideoFile(filename);

            CodecFactory codecFactory = new CodecFactory();
            Codec sourceCodec = codecFactory.ExtractCodec(file);

            Codec destinationCodec;
            if (desiredFormat == "mp4")
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }

            BitrateReader reader = new BitrateReader();
            reader.Read(filename, sourceCodec);
            VideoFile convertedVideo = reader.Convert(filename, destinationCodec);

            return new GeneralFile(convertedVideo.Filename);
        }
    }
}
