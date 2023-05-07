using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.FlyBehaviours
{
    internal class FlyWithWings : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine($"The duck flew!");
        }
    }
}
