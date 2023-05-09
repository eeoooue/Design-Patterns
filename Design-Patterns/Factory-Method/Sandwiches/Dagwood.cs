using Factory_Method.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Sandwiches
{
    internal class Dagwood : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());

            for(int i=0; i<6; i++)
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
