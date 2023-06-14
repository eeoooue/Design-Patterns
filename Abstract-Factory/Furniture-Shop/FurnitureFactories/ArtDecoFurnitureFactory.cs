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
    internal class ArtDecoFurnitureFactory : FurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ArtDecoChair();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public Sofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
