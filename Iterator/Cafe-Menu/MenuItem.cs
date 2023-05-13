using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    public class MenuItem
    {
        string _name;
        string _description;
        bool _vegetarian;
        double _price;
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public string getName()
        {
            return _name;
        }

        public string getDescription()
        {
            return _description;
        }

        public double getPrice()
        {
            return _price;
        }

        public bool isVegetarian()
        {
            return _vegetarian;
        }
    }
}
