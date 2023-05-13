using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    public class CafeMenu : Menu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            true, 3.99);

            AddItem("Soup of the day",
            "A cup of the soup of the day, with a side salad",
            false, 3.69);

            AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole",
            true, 4.29);
        }
        public override void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.getName(), menuItem);
        }
        public Hashtable getItems()
        {
            return menuItems;
        }

        public override Iterator GetIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
