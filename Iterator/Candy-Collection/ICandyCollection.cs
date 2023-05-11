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
}
