using Logistics_App.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_App.LogisticsTypes
{
    internal class SeaLogistics : Logistics
    {
        public Transport CreateTransport()
        {
            return new Ship();
        }

        public void PlanDelivery()
        {
            Console.WriteLine($"The delivery will be made by ship.");
            Transport ship = CreateTransport();
            ship.Deliver();
        }
    }
}
