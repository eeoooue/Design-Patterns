using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe_Menu
{
    internal class Waitress
    {
        public void PrintMenu() { }
        // - prints every item on the menu
        public void PrintBreakfastMenu() { }
        // - prints just breakfast items
        public void PrintLunchMenu() { }
        // - prints just lunch items
        public void PrintVegetarianMenu() { }
        // - prints all vegetarian menu items
        public void IsItemVegetarian(string name) { }
        // - given the name of an item, returns true
        // if the items is vegetarian, otherwise,
        // returns false
    }
}
