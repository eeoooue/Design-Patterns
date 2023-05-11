using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary>
    /// Orders placed by Patrons.
    /// </summary>
    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }

        public Order(FoodItem appetizer, FoodItem entree, FoodItem drink)
        {
            Appetizer = appetizer;
            Entree = entree;
            Drink = drink;
        }
    }
}
