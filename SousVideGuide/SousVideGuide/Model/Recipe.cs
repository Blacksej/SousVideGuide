using System;
using System.Collections.Generic;
using System.Text;

namespace SousVideGuide.Model
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string RecipeImage { get; set; }

        public Recipe(string ingredients, string recipeImage, string recipeName)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            RecipeImage = recipeImage;
        }
    }
}
