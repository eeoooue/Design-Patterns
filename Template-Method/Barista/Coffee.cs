using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
