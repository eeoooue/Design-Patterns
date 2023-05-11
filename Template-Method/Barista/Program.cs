namespace Barista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            tea.PrepareRecipe();
            Console.WriteLine();

            coffee.PrepareRecipe();
            Console.WriteLine();
        }
    }
}