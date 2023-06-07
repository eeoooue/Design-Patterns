using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_App.Transports
{
    internal class Truck : Transport
    {
        public void Deliver()
        {
            Console.WriteLine($"The truck takes the delivery along roads to its destination.");
        }
    }
}
