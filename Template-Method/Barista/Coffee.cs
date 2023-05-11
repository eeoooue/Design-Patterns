using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    public class Coffee : BaristaBeverage
    {
        
        public override void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public override void Brew()
        {
            BrewCoffeeGrinds();
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
