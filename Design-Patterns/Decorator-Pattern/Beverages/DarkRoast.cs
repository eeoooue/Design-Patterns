using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast() : base("A Dark Roast")
        {
        }

        public override decimal Cost()
        {
            return 3.10M;
        }
    }
}
