using Pizza_Ingredients.PizzaIngredientFactories;

namespace Pizza_Ingredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore chicagoStore = new PizzaStore(new ChicagoIngredientFactory());
            PizzaStore newYorkStore = new PizzaStore(new NYIngredientFactory());

            Pizza chicagoPizza = chicagoStore.CreatePizza();
            Pizza newYorkPizza = newYorkStore.CreatePizza();

            DescribePizza(chicagoPizza);
            DescribePizza(newYorkPizza);
        }

        static void DescribePizza(Pizza pizza)
        {
            Console.Write($"It's a pizza with ");

            foreach(Ingredient ingredient in pizza.Ingredients)
            {
                Console.Write($"{ingredient}, ");
            }
            Console.WriteLine();
        }
    }
}