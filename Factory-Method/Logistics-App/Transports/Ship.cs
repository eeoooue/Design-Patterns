using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_App.Transports
{
    internal class Ship : Transport
    {
        public void Deliver()
        {
            Console.WriteLine($"The ship takes the delivery over the sea to its destination.");
        }
    }
}
