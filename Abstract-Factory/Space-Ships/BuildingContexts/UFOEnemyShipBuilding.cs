using Space_Ships.BuildingContexts;
using Space_Ships.EnemyShips;
using Space_Ships.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Ships
{
    internal class UFOEnemyShipBuilding : EnemyShipBuilding
    {
        protected override EnemyShip makeEnemyShip(string typeOfShip)
        {
            EnemyShip theEnemyShip = null;

            // If UFO was sent grab use the factory that knows
            // what types of weapons and engines a regular UFO
            // needs. The EnemyShip object is returned & given a name

            if (typeOfShip == "UFO")
            {
                EnemyShipFactory shipPartsFactory = new UFOEnemyShipFactory();
                theEnemyShip = new UFOEnemyShip(shipPartsFactory);
                theEnemyShip.setName("UFO Grunt Ship");

            }
            else

            // If UFO BOSS was sent grab use the factory that knows
            // what types of weapons and engines a Boss UFO
            // needs. The EnemyShip object is returned & given a name

            if (typeOfShip == "UFO BOSS")
            {
                EnemyShipFactory shipPartsFactory = new UFOBossEnemyShipFactory();
                theEnemyShip = new UFOBossEnemyShip(shipPartsFactory);
                theEnemyShip.setName("UFO Boss Ship");
            }

            return theEnemyShip;
        }
    }
}
