using Restaurant.Restaurants;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant;
            
            restaurant = new BeefBurgerRestaurant();
            Burger burger = restaurant.OrderBurger();
            Console.WriteLine(burger);

            restaurant = new VeggieBurgerRestaurant();
            Burger veggieBurger = restaurant.OrderBurger();
            Console.WriteLine(veggieBurger);
        }
    }
}