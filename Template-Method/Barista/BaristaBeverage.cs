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
            AddCondiments();
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public virtual void PourInMug()
        {
            Console.WriteLine("Pouring into a mug");
        }
        
    }
}
