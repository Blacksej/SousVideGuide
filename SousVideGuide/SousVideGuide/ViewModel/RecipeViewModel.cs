using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    public class RecipeViewModel : BindableObject
    {
        public string RecipeName
        {
            get
            {
                return GetRecipe.RecipeName;
            }
            set
            {
                GetRecipe.RecipeName = value;
                OnPropertyChanged(nameof(RecipeName));
            }
        }

        public string Ingredients
        {
            get
            {
                return GetRecipe.Ingredients.Replace(", ","\n");
            }
            set
            {
                GetRecipe.Ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        public string RecipeImage
        {
            get
            {
                return GetRecipe.RecipeImage;
            }
            set
            {
                GetRecipe.RecipeImage = value;
                OnPropertyChanged(nameof(RecipeImage));
            }
        }

        public Recipe GetRecipe { get; private set; }

        public RecipeViewModel(Recipe recipe)
        {
            GetRecipe = recipe;
        }
    }
}
