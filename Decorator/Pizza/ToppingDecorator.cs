using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class ToppingDecorator : Pizza
    {
        private Pizza _pizza;
        private string _toppingDescription;
        private decimal _price;

        public ToppingDecorator(Pizza pizza, string toppingDescription, decimal price) : base(toppingDescription, price)
        {
            _pizza = pizza;
            _toppingDescription = toppingDescription;
            _price = price;
        }

        public override string GetDescription()
        {
            return $"{_toppingDescription} {_pizza.GetDescription()}";
        }

        public override decimal GetCost()
        {
            return _price + _pizza.GetCost();
        }
    }
}
