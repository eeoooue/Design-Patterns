using Factory_Pattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class ChicagoPizzaFactory : SimplePizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;

            if (type == "cheese")
            {
                pizza = new CheesePizza("Chicago");
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza("Chicago");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza("Chicago");
            }
            else
            {
                pizza = new VeggiePizza("Chicago");
            }

            return pizza;
        }
    }
}
