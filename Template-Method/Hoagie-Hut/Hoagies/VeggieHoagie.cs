using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoagie_Hut.Hoagies
{
    internal class VeggieHoagie : Hoagie
    {

        private string[] veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };

        private string[] condimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese() { }

        public override void AddCondiments()
        {
            Console.Write($"Adding the condiments:");

            foreach (string condiment in condimentsUsed)
            {
                Console.Write($" {condiment}");
            }

            Console.WriteLine();
        }

        public override void AddMeat() { }

        public override void AddVegetables()
        {
            Console.Write($"Adding the vegetables:");

            foreach (string veg in veggiesUsed)
            {
                Console.Write($" {veg}");
            }

            Console.WriteLine();

        }
    }
}
