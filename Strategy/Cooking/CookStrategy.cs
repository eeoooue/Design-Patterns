using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking
{
    abstract class CookStrategy
    {
        /// <summary>
        /// The Strategy abstract class, which defines an 
        /// interface common to all supported strategy algorithms.
        /// </summary>
        public abstract void Cook(string food);
    }
}
