using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Collection
{
    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        IJellyBeanIterator CreateIterator();
    }

    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public IJellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
