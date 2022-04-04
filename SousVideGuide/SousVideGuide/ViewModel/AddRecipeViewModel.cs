using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using Xamarin.Forms;
using System.Drawing;
using Xamarin.Essentials;
using System.Linq;

namespace SousVideGuide.ViewModel
{
    class AddRecipeViewModel : BindableObject
    {
        RecipeRepository recipeRepo;

        private Recipe lastRecipe;

        public Recipe LastRecipe
        {
            get { return lastRecipe; }
            set { lastRecipe = value; }
        }


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


        public FileResult PickedFile { get; internal set; }

        public async void CreateRecipe(string ingredients, string recipeImage, string recipeName, string recipeTime, uint recipeTemp)
        {
            byte[] imageByteArray;
            int imageSize;

            using (Stream stream = await PickedFile.OpenReadAsync())
            {
                imageSize = (int)stream.Length; // File length.
                imageByteArray = new byte[imageSize]; // Allocate image byte array
                stream.Read(imageByteArray, 0, imageSize); // read image int byte array
            }

            Recipe recipeCreated = new Recipe(ingredients, recipeImage, recipeName, recipeTime, recipeTemp, imageByteArray, PickedFile.FileName.Split('.').Last()); // Grabs the last part of the sequence. (filetype).
            LastRecipe = recipeCreated;
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
