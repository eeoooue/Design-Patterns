using Route_Planning.RouteStrategies;

namespace Route_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Navigator satNav = new Navigator(new RoadStrategy());
            satNav.FindRoute("London", "Bristol");

            Navigator busApp = new Navigator(new PublicTransportStrategy());
            busApp.FindRoute("York", "Beverley");
        }
    }
}