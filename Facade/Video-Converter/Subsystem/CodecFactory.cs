using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Converter.Subsystem.Codecs;

namespace Video_Converter.Subsystem
{
    internal class CodecFactory
    {


        public Codec ExtractCodec(VideoFile file)
        {

            return new MPEG4CompressionCodec();
        }
    }
}
