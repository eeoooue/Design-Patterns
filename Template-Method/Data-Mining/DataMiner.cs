using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining
{
    public abstract class DataMiner
    {
        public void Mine(string path)
        {
            OpenFile();
            ExtractData();
            ParseData();
            AnalyzeData();
            SendReport();
            CloseFile();
        }

        protected abstract void OpenFile();

        protected abstract void ExtractData();

        protected abstract void ParseData();

        protected void AnalyzeData()
        {
            Console.WriteLine($"Analysing the parsed data.");
        }

        protected void SendReport()
        {
            Console.WriteLine($"Sending the analysis report.");
        }

        protected abstract void CloseFile();
    }
}
