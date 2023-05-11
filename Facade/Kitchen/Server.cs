using Kitchen.KitchenSections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary>
    /// The actual "Facade" class, which hides the 
    /// complexity of the KitchenSection classes.
    /// After all, there's no reason a patron 
    /// should order each part of their meal individually.
    /// </summary>
    class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Patron patron, int coldAppID, int hotEntreeID, int drinkID)
        {
            Console.WriteLine($"{patron.Name} places order for cold app #{coldAppID}, hot entree #{hotEntreeID}, and drink #{drinkID}.");

            FoodItem appetizer = _coldPrep.PrepDish(coldAppID);
            FoodItem entree = _hotPrep.PrepDish(hotEntreeID);
            FoodItem drink = _bar.PrepDish(drinkID);

            Order order = new Order(appetizer, entree, drink);

            return order;
        }
    }
}
