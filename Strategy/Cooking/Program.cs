using Cooking.CookStrategies;

namespace Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What food would you like to cook?");
            string food = Console.ReadLine();

            CookingMethod cookMethod = ChooseCookingMethod();
            cookMethod.Cook(food);

            Console.ReadKey();
        }

        private static CookingMethod ChooseCookingMethod()
        {
            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    return new CookingMethod(new Grilling());
                case 2:
                    return new CookingMethod(new OvenBaking());
                case 3:
                    return new CookingMethod(new DeepFrying());
                default:
                    Console.WriteLine("Invalid Selection!");
                    return ChooseCookingMethod();
            }
        }
    }
}