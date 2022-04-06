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
        private ObservableCollection<string> tempIngredientStorage;

        public ObservableCollection<string> TempIngredientStorage
        {
            get { return tempIngredientStorage; }
            set 
            {
                tempIngredientStorage = value;
                OnPropertyChanged(nameof(TempIngredientStorage));
            }
        }

        RecipeRepository recipeRepo;

        private Recipe lastRecipe;

        public Recipe LastRecipe
        {
            get { return lastRecipe; }
            set { lastRecipe = value; }
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

        private string ingredient;
        public string Ingredient
        {
            get
            {
                return ingredient;
            }
            set
            {
                ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
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

        public async void CreateRecipe(string recipeImage, string recipeName, string recipeTime, uint recipeTemp)
        {
            byte[] imageByteArray;
            int imageSize;

            using (Stream stream = await PickedFile.OpenReadAsync())
            {
                imageSize = (int)stream.Length; // File length.
                imageByteArray = new byte[imageSize]; // Allocate image byte array
                stream.Read(imageByteArray, 0, imageSize); // read image int byte array
            }

            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (var item in TempIngredientStorage)
            {
                Ingredient ingredient = new Ingredient(item);
                ingredients.Add(ingredient);
            }

            Recipe recipeCreated = new Recipe(ingredients, recipeImage, recipeName, recipeTime, recipeTemp, imageByteArray, PickedFile.FileName.Split('.').Last()); // Grabs the last part of the sequence. (filetype).
            LastRecipe = recipeCreated;
            recipeRepo.CreateRecipe(recipeCreated);
        }


        public void CreateRecipe()
        {
            CreateRecipe(RecipeImage, RecipeName, RecipeTime, RecipeTemp);
        }

        public void AddIngredientTemp(string ingredientAdded)
        {
            tempIngredientStorage.Add(ingredientAdded);
        }

        public void AddIngredientTemp()
        {
            AddIngredientTemp(Ingredient);
        }

        public AddRecipeViewModel()
        {
            tempIngredientStorage = new ObservableCollection<string>();
            recipeRepo = new RecipeRepository();
        }
    }
}
