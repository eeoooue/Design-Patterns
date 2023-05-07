using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages.Condiments
{
    internal class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage) : base("whipped cream")
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.60M;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}
