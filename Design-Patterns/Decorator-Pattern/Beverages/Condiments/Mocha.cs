using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage) : base("mocha")
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.80M;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}
