namespace Kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            string name = Console.ReadLine();

            Patron patron = new Patron(name);

            Console.WriteLine($"Hello {patron.Name}. What appetizer would you like? (1-15):");
            int appID = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            int entreeID = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            int drinkID = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            //Here's what the Facade simplifies
            server.PlaceOrder(patron, appID, entreeID, drinkID);

            Console.ReadKey();
        }
    }
}