using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Ships
{
    public abstract class EnemyShip
    {
        private string name;

        // Newly defined objects that represent weapon & engine
        // These can be changed easily by assigning new parts 
        // in UFOEnemyShipFactory or UFOBossEnemyShipFactory

        protected ESWeapon weapon;
        protected ESEngine engine;

        public string getName() { return name; }
        public void setName(string newName) { name = newName; }

        public abstract void makeShip();

        // Because I defined the toString method in engine
        // when it is printed the String defined in toString goes
        // on the screen

        public void followHeroShip()
        {
            Console.WriteLine($"{name} is following the hero at {engine}");
        }

        public void displayEnemyShip()
        {
            Console.WriteLine($"{name} is on the screen");
        }

        public void enemyShipShoots()
        {
            Console.WriteLine($"{name} attacks and does {weapon}");
        }

        // If any EnemyShip object is printed to screen this shows up

        public string toString()
        {
            string infoOnShip = $"The {name} has a top speed of {engine} and an attack power of {weapon}";

            return infoOnShip;
        }

    }
}
