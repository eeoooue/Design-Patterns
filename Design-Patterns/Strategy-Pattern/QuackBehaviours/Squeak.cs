using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.QuackBehaviours
{
    internal class Squeak : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"The duck squeaked. 'Squeak!'");
        }
    }
}
