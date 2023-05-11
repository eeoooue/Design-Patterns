using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    public abstract class BaristaBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInMug();
            AddSugarAndMilk();
        }

        public abstract void BoilWater();

        public abstract void Brew();

        public virtual void PourInMug()
        {
            Console.WriteLine("Pouring into a mug");
        }
        public virtual void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
