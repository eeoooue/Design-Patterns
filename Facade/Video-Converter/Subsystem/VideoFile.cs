using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Converter.Subsystem
{
    internal class VideoFile
    {
        public string Filename { get; private set; }

        public VideoFile(string filepath)
        {
            Filename = filepath;
        }
    }
}
