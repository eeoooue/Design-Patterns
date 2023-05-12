using Pizza_Ingredients.Ingredients.Cheeses;
using Pizza_Ingredients.Ingredients.Doughs;
using Pizza_Ingredients.Ingredients.Sauces;

namespace Pizza_Ingredients.PizzaIngredientFactories
{
    internal class NYIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }
    }
}
