using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    abstract class Duck
    {
        public QuackBehaviour _quackBehaviour;
        public FlyBehaviour _flyBehaviour;

        public Duck(QuackBehaviour quackBehaviour, FlyBehaviour flyBehaviour)
        {
            _quackBehaviour = quackBehaviour;
            _flyBehaviour = flyBehaviour;
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine($"The duck swam.");
        }

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public abstract void Display();
    }
}
