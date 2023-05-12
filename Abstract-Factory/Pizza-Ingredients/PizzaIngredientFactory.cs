using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    interface PizzaIngredientFactory
    {
        abstract Dough CreateDough();

        abstract Sauce createSauce();

        abstract Cheese createCheese();
    }
}
