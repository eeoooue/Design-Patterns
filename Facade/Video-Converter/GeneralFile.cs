using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Converter
{
    internal class GeneralFile
    {
        public string Filename { get; private set; }
        public GeneralFile(string filename)
        {
            Filename = filename;
        }
    }
}
