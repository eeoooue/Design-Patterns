namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Burger burger = restaurant.OrderBurger("beef");
            Console.WriteLine(burger);

            Burger veggieBurger = restaurant.OrderBurger("veggie");
            Console.WriteLine(veggieBurger);
        }
    }
}