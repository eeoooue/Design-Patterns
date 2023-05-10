using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    abstract internal class CondimentDecorator : Beverage
    {
        protected CondimentDecorator(string description) : base(description)
        {
        }

        public abstract override string GetDescription();
    }

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
