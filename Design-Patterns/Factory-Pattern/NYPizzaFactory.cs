using Factory_Pattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class NYPizzaFactory : SimplePizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;

            if (type == "cheese")
            {
                pizza = new CheesePizza("New York");
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza("New York");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza("New York");
            }
            else
            {
                pizza = new VeggiePizza("New York");
            }

            return pizza;
        }


    }
}
