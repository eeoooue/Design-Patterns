using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    public interface Iterator
    {
        public bool HasNext();

        public object Next();
    }
}
