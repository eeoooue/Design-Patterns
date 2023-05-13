using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    internal class CafeMenuIterator : Iterator
    {

        List<MenuItem> _items;
        int position = 0;

        public CafeMenuIterator(Hashtable menuItems)
        {
            _items = new List<MenuItem>();
            foreach(var item in menuItems.Values)
            {
                if (item is MenuItem menuItem)
                {
                    _items.Add(menuItem);
                }
            }
        }

        public bool HasNext()
        {
            return (position < _items.Count && _items[position] != null);
        }

        public object Next()
        {
            return _items[position++];
        }
    }
}
