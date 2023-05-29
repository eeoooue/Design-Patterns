using Pizza.Pizzas;
using Pizza.ToppingDecorators;

namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new DeepPanPizza();

            pizza = new JalapenoTopping(pizza);
            pizza = new CheeseTopping(pizza);
            pizza = new MozzarellaTopping(pizza);

            Console.WriteLine($"Here's your {pizza.GetDescription()}!");
            Console.WriteLine($"That'll be ${pizza.GetCost()}.");
        }
    }
}