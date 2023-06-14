using Furniture_Shop.FurnitureFactories;

namespace Furniture_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory factory = new VictorianFurnitureFactory();

            Chair chair = factory.CreateChair();
            Console.WriteLine(chair);
        }
    }
}