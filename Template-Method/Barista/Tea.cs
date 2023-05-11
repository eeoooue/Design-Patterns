using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    internal class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddSugarAndMilk();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void SteepTeaBag()
        {
            Console.WriteLine("Dripping Tea through filter");
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
