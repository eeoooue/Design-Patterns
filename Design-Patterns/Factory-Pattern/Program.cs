using Factory_Pattern.PizzaStores;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore newYorkStore = new NYPizzaStore();

            TryOrderPizza(chicagoStore, "cheese");
            TryOrderPizza(newYorkStore, "cheese");
        }

        static void TryOrderPizza(PizzaStore store, string type)
        {
            Pizza myPizza = store.OrderPizza(type);
            Console.WriteLine($"I ordered a pizza & received a {myPizza._style} style pizza");
        }
    }
}