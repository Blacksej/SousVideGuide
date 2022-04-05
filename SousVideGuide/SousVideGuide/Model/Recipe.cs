using System;
using System.Collections.Generic;
using System.IO;
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

        public string FileType { get; set; }
        public byte[] Image { get; set; }
        public MemoryStream Stream { get => new MemoryStream(Image); }


        public Recipe(string ingredients, string recipeImage, string recipeName, string recipeTime, uint recipeTemp, byte[] image, string fileType)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            RecipeImage = recipeImage;
            RecipeTime = recipeTime;
            RecipeTemp = recipeTemp;

            Image = image;
            FileType = fileType;
        }
    }
}