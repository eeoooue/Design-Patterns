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

    internal class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new Quacking(), new FlyWithWings()) { }

        public override void Display()
        {
            Console.WriteLine($"Look, it's a Redhead duck!");
        }
    }

    internal class MallardDuck : Duck
    {
        public MallardDuck() : base(new Quacking(), new FlyWithWings()) { }

        public override void Display()
        {
            Console.WriteLine($"Look, it's a Mallard duck!");
        }
    }

    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(new Squeak(), new FlyNoWay()) { }

        public override void Display()
        {
            Console.WriteLine($"Look, it's a Rubber duck!");
        }
    }
}
