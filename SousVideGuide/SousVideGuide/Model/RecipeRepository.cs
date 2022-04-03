using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SousVideGuide.Model
{
    public class RecipeRepository
    {
        static List<Recipe> recipesList = new List<Recipe>()
        { 
            new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 5 Bay Leaves, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika, 1tsp Chili Powder", "pulledpork.jpg", "Pulled Pork", "24", 73),
            new Recipe("2L Water, 50g Sugar, 10 Peppercorn, 5 Bay Leaves, 2kg Pork Shoulder, 2tbsp Paprika, 1tsp Chili Powder", "ribeye.jpg", "Rib Eye Steak", "1.5", 56),
            new Recipe("2L Water, 100g Salt, 50g Sugar, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika", "porktenderloin.jpg", "Pork Tenderloin", "1.5", 58),
            new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 4tbsp Brown Sugar, 2tbsp Paprika", "cheesecake.jpg", "Cheesecake", "1.5", 80),
            new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika", "duck.jpg", "Duck Breast", "2", 58),
            new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika", "legoflamb.jpg", "Leg of Lamb", "24", 60),
            new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika", "roastpork.jpg", "Roast Pork", "6", 60)
        };

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipesList;
        }

        public void CreateRecipe(Recipe recipeCreated)
        {
            recipesList.Add(recipeCreated);
        }
    }
}
