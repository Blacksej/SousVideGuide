using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    class AddRecipeViewModel : BindableObject
    {
        RecipeRepository recipeRepo;

        private ObservableCollection<Recipe> recipesList;

        public ObservableCollection<Recipe> RecipesList
        {
            get { return recipesList; }
            set
            {
                recipesList = value;
                OnPropertyChanged(nameof(RecipesList));
            }
        }

        private string recipeName;
        public string RecipeName
        {
            get
            {
                return recipeName;
            }
            set
            {
                recipeName = value;
                OnPropertyChanged(nameof(RecipeName));
            }
        }

        private string ingredients;
        public string Ingredients
        {
            get
            {
                return ingredients;
            }
            set
            {
                ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        private string recipeImage;
        public string RecipeImage
        {
            get
            {
                return recipeImage;
            }
            set
            {
                recipeImage = value;
                OnPropertyChanged(nameof(RecipeImage));
            }
        }

        private string recipeTime;
        public string RecipeTime
        {
            get
            {
                return recipeTime;
            }
            set
            {
                recipeTime = value;
                OnPropertyChanged(nameof(RecipeTime));
            }
        }

        private uint recipeTemp;
        public uint RecipeTemp
        {
            get
            {
                return recipeTemp;
            }
            set
            {
                recipeTemp = value;
                OnPropertyChanged(nameof(RecipeTemp));
            }
        }

        public void CreateRecipe(string ingredients, string recipeImage, string recipeName, string recipeTime, uint recipeTemp)
        {
            Recipe recipeCreated = new Recipe(ingredients, recipeImage, recipeName, recipeTime, recipeTemp);

            recipeRepo.CreateRecipe(recipeCreated);
        }

        public void CreateRecipe()
        {
            CreateRecipe(Ingredients, RecipeImage, RecipeName, RecipeTime, RecipeTemp);
        }

        public AddRecipeViewModel()
        {
            recipeRepo = new RecipeRepository();
        }
    }
}
