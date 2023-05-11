using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    internal class Tea : BaristaBeverage
    {
        public override void AddCondiments()
        {
            AddLemon();
        }

        public override void Brew()
        {
            SteepTeaBag();
        }

        private void AddLemon()
        {
            Console.WriteLine("Adding the juice of a lemon");
        }

        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
