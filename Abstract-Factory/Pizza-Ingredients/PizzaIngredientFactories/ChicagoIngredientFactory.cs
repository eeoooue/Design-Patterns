using Pizza_Ingredients.Ingredients.Cheeses;
using Pizza_Ingredients.Ingredients.Doughs;
using Pizza_Ingredients.Ingredients.Sauces;

namespace Pizza_Ingredients.PizzaIngredientFactories
{
    internal class ChicagoIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }
    }
}
