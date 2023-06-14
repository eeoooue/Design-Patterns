using Furniture_Shop.Chairs;
using Furniture_Shop.CoffeeTables;
using Furniture_Shop.Sofas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Shop.FurnitureFactories
{
    internal class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
