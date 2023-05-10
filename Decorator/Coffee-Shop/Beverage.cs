using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    abstract class Beverage
    {

        protected string _description;

        public Beverage(string description)
        {
            _description = description;
        }

        public abstract decimal Cost();

        public virtual string GetDescription()
        {
            return _description;
        }

    }

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
