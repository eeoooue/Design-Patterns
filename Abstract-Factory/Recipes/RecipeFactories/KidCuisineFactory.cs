using Recipes.Deserts;
using Recipes.Sandwiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.RecipeFactories
{
    /// <summary>
    /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    class KidCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}
