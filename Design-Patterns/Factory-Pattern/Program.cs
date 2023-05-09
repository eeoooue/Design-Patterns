namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ChicagoPizzaFactory chicagoFactory = new ChicagoPizzaFactory();
            NYPizzaFactory newYorkFactory = new NYPizzaFactory();

            PizzaShop chicagoStore = new PizzaShop(chicagoFactory);
            PizzaShop newYorkStore = new PizzaShop(newYorkFactory);

            TryOrderPizza(chicagoStore, "cheese");
            TryOrderPizza(newYorkStore, "cheese");
        }

        static void TryOrderPizza(PizzaShop store, string type)
        {
            Pizza myPizza = store.OrderPizza(type);

            Console.WriteLine($"I ordered a pizza & received a {myPizza._style} style pizza");
        }
    }
}