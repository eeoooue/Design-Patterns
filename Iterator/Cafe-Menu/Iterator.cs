using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    public interface Iterator
    {
        public bool HasNext();

        public object Next();
    }
}
