using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages.Condiments
{
    internal class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage) : base("milk")
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.20M;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}
