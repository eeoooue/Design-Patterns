using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    internal class HouseBlend : Beverage
    {
        public HouseBlend() : base("Our signature House Blend")
        {
        }

        public override decimal Cost()
        {
            return 3.60M;
        }
    }
}
