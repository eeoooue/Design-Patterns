using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    internal class Expresso : Beverage
    {
        public Expresso() : base("An Expresso")
        {
        }

        

        public override decimal Cost()
        {
            return 3.80M;
        }
    }
}
