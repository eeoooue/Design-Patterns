using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cafe_Menu
{
    internal class Waitress
    {
        private PancakeHouseMenu breakfastMenu = new PancakeHouseMenu();
        private DinerMenu lunchMenu = new DinerMenu();

        public void PrintMenu()
        {
            PrintBreakfastMenu();
            PrintLunchMenu();
        }

        public void PrintBreakfastMenu()
        {
            ArrayList breakfastItems = breakfastMenu.GetMenuItems();
            foreach(MenuItem item in breakfastItems)
            {
                PrintMenuItem(item);
            }
        }

        public void PrintLunchMenu()
        {
            MenuItem[] lunchItems = lunchMenu.GetMenuItems();
            foreach(MenuItem item in lunchItems)
            {
                if (item != null)
                {
                    PrintMenuItem(item);
                }
            }
        }

        public void PrintVegetarianMenu()
        {
            ArrayList breakfastItems = breakfastMenu.GetMenuItems();
            foreach (MenuItem item in breakfastItems)
            {
                if (item.isVegetarian())
                {
                    PrintMenuItem(item);
                }
            }


            MenuItem[] lunchItems = lunchMenu.GetMenuItems();
            foreach (MenuItem item in lunchItems)
            {
                if (item != null && item.isVegetarian())
                {
                    PrintMenuItem(item);
                }
            }
        }


        public void IsItemVegetarian(string name) { }
        // - given the name of an item, returns true
        // if the items is vegetarian, otherwise,
        // returns false


        private void PrintMenuItem(MenuItem menuItem)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" ${menuItem.getPrice()} : {menuItem.getName()} - ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(menuItem.getDescription());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
