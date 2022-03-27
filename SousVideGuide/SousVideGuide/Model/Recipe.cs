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
        public string RecipeTime { get; set; }
        public uint RecipeTemp { get; set; }

        public Recipe(string ingredients, string recipeImage, string recipeName, string recipeTime, uint recipeTemp)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            RecipeImage = recipeImage;
            RecipeTime = recipeTime;
            RecipeTemp = recipeTemp;
        }
    }
}
