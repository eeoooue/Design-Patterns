using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    internal class PizzaStore
    {

        private PizzaIngredientFactory _factory;

        public PizzaStore(PizzaIngredientFactory factory)
        {
            _factory = factory;
        }

        public Pizza CreatePizza()
        {
            Dough dough = _factory.CreateDough();
            Sauce sauce = _factory.createSauce();
            Cheese cheese = _factory.createCheese();

            Pizza pizza = new Pizza(dough);
            pizza.AddIngredient(sauce);
            pizza.AddIngredient(cheese);
            
            return pizza;
        }
    }
}
