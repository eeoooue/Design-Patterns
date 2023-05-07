using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine($"Quack, said the duck.");
        }

        public void Swim()
        {
            Console.WriteLine($"The duck swam.");
        }

        public void Fly()
        {
            Console.WriteLine($"The duck flew!");
        }

        public abstract void Display();
    }
}
