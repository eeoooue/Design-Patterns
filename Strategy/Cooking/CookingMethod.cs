using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    class CookingMethod
    {
        private CookStrategy _cookStrategy;

        public CookingMethod(CookStrategy strategy)
        {
            _cookStrategy = strategy;
        }

        public void Cook(string food)
        {
            _cookStrategy.Cook(food);
            Console.WriteLine();
        }
    }
}
