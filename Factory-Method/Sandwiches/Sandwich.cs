using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwiches
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

    internal class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Bread());
        }
    }

    internal class Dagwood : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());

            for (int i = 0; i < 6; i++)
            {
                Ingredients.Add(new Mayonnaise());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Turkey());
                Ingredients.Add(new Lettuce());
                Ingredients.Add(new Bread());
            }
        }
    }
}
