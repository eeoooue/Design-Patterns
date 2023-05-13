using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    public abstract class Menu
    {
        public abstract void AddItem(string name, string description, bool vegetarian, double price);

        public abstract Iterator GetIterator();
    }
}
