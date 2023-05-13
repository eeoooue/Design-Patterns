namespace Cafe_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress();

            Console.WriteLine($"Full Menu:");
            waitress.PrintMenu();

            Console.WriteLine();

            Console.WriteLine($"Vegetarian only:");
            waitress.PrintVegetarianMenu();
        }
    }
}