﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Planning.RouteStrategies
{
    internal class WalkStrategy : RouteStrategy
    {
        public void BuildRoute(string start, string destination)
        {
            Console.WriteLine($"Built a route for walking from {start} to {destination}");
        }
    }
}
