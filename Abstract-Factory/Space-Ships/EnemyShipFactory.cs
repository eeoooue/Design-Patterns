using Space_Ships.EnemyShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Ships
{
    internal class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string shipType)
        {
            switch (shipType)
            {
                case "R":
                    return new RocketEnemyShip();
                case "B":
                    return new BigUFOEnemyShip();
                case "U":
                default:
                    return new UFOEnemyShip();
            }
        }
    }
}
