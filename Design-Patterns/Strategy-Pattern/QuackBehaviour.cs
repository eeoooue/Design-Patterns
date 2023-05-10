using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    interface QuackBehaviour
    {
        void Quack();
    }

    internal class Quacking : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"The duck quacked. 'Quack!'");
        }
    }

    internal class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"This duck can't quack.");
        }
    }

    internal class Squeak : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"The duck squeaked. 'Squeak!'");
        }
    }
}
