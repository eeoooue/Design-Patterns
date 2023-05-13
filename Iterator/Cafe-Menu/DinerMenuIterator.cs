using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    internal class DinerMenuIterator : Iterator
    {
        private MenuItem[] _items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _items = menuItems;
        }

        public bool HasNext()
        {
            return (position < _items.Length && _items[position] != null);
        }

        public object Next()
        {
            return _items[position++];
        }
    }
}
