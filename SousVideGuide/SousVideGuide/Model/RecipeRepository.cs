using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SousVideGuide.Model
{
    public class RecipeRepository
    {
        static List<Recipe> recipesList = new List<Recipe>();

        public ICollection<Recipe> GetRecipes()
        {
            return recipesList;
        }

        public void CreateRecipe(Recipe recipeCreated)
        {
            recipesList.Add(recipeCreated);
        }
    }
}
