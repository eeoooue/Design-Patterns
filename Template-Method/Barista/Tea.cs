using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    internal class Tea : BaristaBeverage
    {
        public override void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public override void Brew()
        {
            SteepTeaBag();
        }
        private void SteepTeaBag()
        {
            Console.WriteLine("Dripping Tea through filter");
        }
        
    }
}
