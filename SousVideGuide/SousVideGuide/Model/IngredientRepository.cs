using System;
using System.Collections.Generic;
using System.Text;

namespace SousVideGuide.Model
{
    class IngredientRepository
    {
        static private List<Ingredient> ingredientsList = new List<Ingredient>();

        public IEnumerable<Ingredient> GetIngredients()
        {
            return ingredientsList;
        }

        public void CreateIngredient(Ingredient ingredientCreated)
        {
            ingredientsList.Add(ingredientCreated);
        }
    }
}
