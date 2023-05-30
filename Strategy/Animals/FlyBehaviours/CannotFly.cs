using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.FlyBehaviours
{
    internal class CannotFly : Flys
    {
        public string Fly()
        {
            return "I can't fly!";
        }
    }
}
