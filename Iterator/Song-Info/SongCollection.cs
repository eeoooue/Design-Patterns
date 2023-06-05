using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song_Info
{
    internal interface SongCollection
    {
        public Iterator CreateIterator();
    }
}
