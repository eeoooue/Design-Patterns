using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Planning
{
    internal class Navigator
    {
        private RouteStrategy _strategy;

        public Navigator(RouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void FindRoute(string start, string end)
        {
            _strategy.BuildRoute(start, end);
        }
    }
}
