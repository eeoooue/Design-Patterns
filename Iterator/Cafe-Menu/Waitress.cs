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
        private Menu breakfastMenu = new PancakeHouseMenu();
        private Menu lunchMenu = new CafeMenu();
        private Menu dinnerMenu = new DinerMenu();

        public void PrintMenu()
        {
            Console.WriteLine("----- Breakfast -----");
            PrintBreakfastMenu();
            Console.WriteLine();

            Console.WriteLine("----- Lunch -----");
            PrintLunchMenu();
            Console.WriteLine();

            Console.WriteLine("----- Dinner -----");
            PrintDinnerMenu();
            Console.WriteLine();
        }

        public void PrintBreakfastMenu()
        {
            PrintFromIterator(breakfastMenu.GetIterator());
        }

        public void PrintLunchMenu()
        {
            PrintFromIterator(lunchMenu.GetIterator());
        }

        public void PrintDinnerMenu()
        {
            PrintFromIterator(dinnerMenu.GetIterator());
        }

        public void PrintVegetarianMenu()
        {
            PrintVegetarianOptionsFromIterator(breakfastMenu.GetIterator());
            PrintVegetarianOptionsFromIterator(lunchMenu.GetIterator());
            PrintVegetarianOptionsFromIterator(dinnerMenu.GetIterator());
        }

        private void PrintMenuItem(MenuItem menuItem)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" ${menuItem.getPrice()} : {menuItem.getName()} - ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(menuItem.getDescription());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void PrintFromIterator(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                Object item = iterator.Next();
                if (item is MenuItem menuItem)
                {
                    PrintMenuItem(menuItem);
                }
            }
        }

        private void PrintVegetarianOptionsFromIterator(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                Object item = iterator.Next();
                if (item is MenuItem menuItem && menuItem.isVegetarian())
                {
                    PrintMenuItem(menuItem);
                }
            }
        }
    }
}
