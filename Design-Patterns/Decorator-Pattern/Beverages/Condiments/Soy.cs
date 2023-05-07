using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages.Condiments
{
    internal class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage) : base("soy")
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return _beverage.Cost() + 0.15M;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + _description;
        }
    }
}
