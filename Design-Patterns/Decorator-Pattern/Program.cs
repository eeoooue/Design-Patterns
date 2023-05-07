
using Decorator_Pattern.Beverages;
using Decorator_Pattern.Beverages.Condiments;

namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Beverage myCoffee = new HouseBlend();

            myCoffee = new Milk(myCoffee);
            myCoffee = new Whip(myCoffee);

            Console.WriteLine($"{myCoffee.GetDescription()} for {myCoffee.Cost()}");



        }
    }
}