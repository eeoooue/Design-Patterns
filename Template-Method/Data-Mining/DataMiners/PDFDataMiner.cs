using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining.DataMiners
{
    internal class PDFDataMiner : DataMiner
    {
        protected override void OpenFile()
        {
            Console.WriteLine($"Opening the .pdf file");
        }

        protected override void ExtractData()
        {
            Console.WriteLine($"Extracting data from the the .pdf file");
        }

        protected override void ParseData()
        {
            Console.WriteLine($"Parsing the extracted data from the .pdf file");
        }

        protected override void CloseFile()
        {
            Console.WriteLine($"Closing the .pdf file");
        }
    }
}
