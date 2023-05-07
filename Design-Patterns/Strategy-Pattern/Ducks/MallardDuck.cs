using Strategy_Pattern.FlyBehaviours;
using Strategy_Pattern.QuackBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() : base(new Quacking(), new FlyWithWings())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"Look, it's a Mallard duck!");
        }
    }
}
