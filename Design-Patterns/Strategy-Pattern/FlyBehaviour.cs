using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    interface FlyBehaviour
    {
        void Fly();
    }

    internal class FlyWithWings : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine($"The duck flew!");
        }
    }

    internal class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine($"The duck can't fly.");
        }
    }
}
