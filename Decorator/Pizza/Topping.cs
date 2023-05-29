using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Topping : Pizza
    {

        private Pizza _pizza;

        private string _toppingDescription;

        public Topping(Pizza pizza, string toppingDescription)
        {
            _pizza = pizza;
            _toppingDescription = toppingDescription;
        }

        public override string GetDescription()
        {
            return $"{_toppingDescription} {_pizza.GetDescription()}";
        }
    }
}
