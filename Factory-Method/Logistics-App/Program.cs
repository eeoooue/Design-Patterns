using Logistics_App.LogisticsTypes;

namespace Logistics_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logistics roadApp = new RoadLogistics();
            roadApp.PlanDelivery();

            Console.WriteLine();

            Logistics seaApp = new SeaLogistics();
            seaApp.PlanDelivery();
        }
    }
}