using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.QuackBehaviours
{
    internal class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"This duck can't quack.");
        }
    }
}
