using Factory_Pattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class PizzaShop
    {


        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
            }
            else
            {
                pizza = new VeggiePizza();
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
