using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Stores
{
    abstract class PizzaStore
    {
        public PizzaStore() { }

        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }

    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
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

    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
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
