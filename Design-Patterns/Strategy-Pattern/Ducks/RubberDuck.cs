using Strategy_Pattern.FlyBehaviours;
using Strategy_Pattern.QuackBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(new Squeak(), new FlyNoWay())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"Look, it's a Rubber duck!");
        }
    }
}
