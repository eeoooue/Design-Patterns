using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    internal class Decaf : Beverage
    {
        public Decaf() : base("A Decaf")
        {
        }

        public override decimal Cost()
        {
            return 2.90M;
        }
    }
}
