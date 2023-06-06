namespace Space_Ships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnemyShipFactory factory = new EnemyShipFactory();

            Console.WriteLine($"What kind of ship? (U / R / B)");

            string userInput = Console.ReadLine();

            EnemyShip ship = factory.MakeEnemyShip(userInput);

            Console.WriteLine($"A {ship.Name} was made! (Speed: {ship.Speed}, Damage: {ship.Damage})");
        }
    }
}