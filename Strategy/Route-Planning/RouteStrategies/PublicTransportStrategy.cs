using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Planning.RouteStrategies
{
    internal class PublicTransportStrategy : RouteStrategy
    {
        public void BuildRoute(string start, string destination)
        {
            Console.WriteLine($"Built a route for getting from {start} to {destination} via public transport");
        }
    }
}
