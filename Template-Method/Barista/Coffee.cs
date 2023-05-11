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
        public override void AddCondiments()
        {
            AddSugarAndMilk();
        }

        public override void Brew()
        {
            BrewCoffeeGrinds();
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
