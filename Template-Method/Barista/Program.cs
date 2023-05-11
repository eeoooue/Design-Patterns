namespace Barista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaristaBeverage tea = new Tea();
            BaristaBeverage coffee = new Coffee();

            tea.PrepareRecipe();
            Console.WriteLine();

            coffee.PrepareRecipe();
            Console.WriteLine();
        }
    }
}