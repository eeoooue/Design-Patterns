using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ingredients
{
    internal class Pizza
    {
        private List<Ingredient> _ingredients = new();

        public List<Ingredient> Ingredients { get { return _ingredients; } }
        public Pizza(Dough dough)
        {
            AddIngredient(dough);
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }
    }
}
