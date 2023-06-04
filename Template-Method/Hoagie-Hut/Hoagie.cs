using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoagie_Hut
{
    abstract class Hoagie
    {
        public string Name { get; private set; }


        public Hoagie(string name)
        {
            Name = name;
        }

        public void MakeSandwich()
        {
            Console.WriteLine($"Fulfilling order for: '{Name}'");

            CutBun();

            if (CustomerWantsMeat())
            {
                AddMeat();
            }

            if (CustomerWantsCheese())
            {
                AddCheese();
            }

            if (CustomerWantsVegetables())
            {
                AddVegetables();
            }

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }

            WrapTheHoagie();

            Console.WriteLine();
        }

        public void CutBun()
        {
            Console.WriteLine($" - The hoagie is cut.");
        }

        public void WrapTheHoagie()
        {
            Console.WriteLine($" - Wrap the hoagie.");
        }

        public virtual bool CustomerWantsMeat()
        {
            return true;
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public virtual bool CustomerWantsCheese()
        {
            return true;
        }

        public virtual bool CustomerWantsVegetables()
        {
            return true;
        }

        abstract public void AddCheese();

        abstract public void AddCondiments();

        abstract public void AddMeat();

        abstract public void AddVegetables();
    }
}
