namespace Coffee_Shop
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