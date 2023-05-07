using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.QuackBehaviours
{
    internal class Quacking : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine($"The duck quacked. 'Quack!'");
        }
    }
}
