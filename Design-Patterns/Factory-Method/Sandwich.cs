using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public List<Ingredient> Ingredients { get { return _ingredients; } }

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();
    }
}
