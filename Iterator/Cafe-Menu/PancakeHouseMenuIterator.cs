using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    internal class PancakeHouseMenuIterator : Iterator
    {

        private ArrayList _items;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _items = menuItems;
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
