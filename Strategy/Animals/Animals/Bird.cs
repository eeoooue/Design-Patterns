using Animals.FlyBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animals
{
    internal class Bird : Animal
    {
        public Bird()
        {
            SetName("bird");
            SetFlyingType(new ItFlys());
        }
    }
}
