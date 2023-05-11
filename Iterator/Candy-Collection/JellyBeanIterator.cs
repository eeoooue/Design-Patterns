using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Collection
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;
        public JellyBean CurrentBean { get { return _jellyBeans[_current]; } }
        public bool IsDone { get { return _current >= _jellyBeans.Count; } }

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            _jellyBeans = beans;
        }

        // Gets first jelly bean
        public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current];
        }

        // Gets next jelly bean
        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current];
            else
                return null;
        }
    }
}
