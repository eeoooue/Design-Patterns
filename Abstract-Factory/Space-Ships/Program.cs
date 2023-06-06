namespace Space_Ships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EnemyShipBuilding handles orders for new EnemyShips
            // You send it a code using the orderTheShip method &
            // it sends the order to the right factory for creation

            EnemyShipBuilding MakeUFOs = new UFOEnemyShipBuilding();

            EnemyShip theGrunt = MakeUFOs.orderTheShip("UFO");
            Console.WriteLine();

            EnemyShip theBoss = MakeUFOs.orderTheShip("UFO BOSS");
        }
    }
}