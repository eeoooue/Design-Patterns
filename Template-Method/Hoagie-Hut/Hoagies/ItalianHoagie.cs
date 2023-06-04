using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoagie_Hut.Hoagies
{
    internal class ItalianHoagie : Hoagie
    {
        private string[] meatUsed = { "Salami", "Pepperoni", "Capicola Ham" };

        private string[] cheeseUsed = { "Provolone" };

        private string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };

        private string[] condimentsUsed = { "Oil", "Vinegar" };

        public ItalianHoagie() : base("Italian Hoagie") { }

        public override void AddCheese()
        {
            Console.Write($" - Adding the cheese:");

            foreach (string cheese in cheeseUsed)
            {
                Console.Write($" {cheese}");
            }

            Console.WriteLine();
        }

        public override void AddCondiments()
        {
            Console.Write($" - Adding the condiments:");

            foreach (string condiment in condimentsUsed)
            {
                Console.Write($" {condiment}");
            }

            Console.WriteLine();
        }

        public override void AddMeat()
        {
            Console.Write($" - Adding the meat:");

            foreach(string meat in meatUsed)
            {
                Console.Write($" {meat}");
            }

            Console.WriteLine();
        }

        public override void AddVegetables()
        {
            Console.Write($" - Adding the vegetables:");

            foreach (string veg in veggiesUsed)
            {
                Console.Write($" {veg}");
            }

            Console.WriteLine();

        }
    }
}
