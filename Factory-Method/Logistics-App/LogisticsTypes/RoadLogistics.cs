using Logistics_App.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_App.LogisticsTypes
{
    internal class RoadLogistics : Logistics
    {
        public Transport CreateTransport()
        {
            return new Truck();
        }

        public void PlanDelivery()
        {
            Console.WriteLine($"The delivery will be made by truck.");
            Transport truck = CreateTransport();
            truck.Deliver();
        }
    }
}
