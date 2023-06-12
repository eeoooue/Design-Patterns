using Data_Mining.DataMiners;

namespace Data_Mining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMiner miner = new PDFDataMiner();
            miner.Mine("example.pdf");
        }
    }
}