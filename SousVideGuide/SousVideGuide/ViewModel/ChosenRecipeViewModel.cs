using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    class ChosenRecipeViewModel : BindableObject
    {
        private RecipeViewModel chosenRecipe;

        public RecipeViewModel ChosenRecipe
        {
            get
            {
                return chosenRecipe;
            }
            set
            {
                chosenRecipe = value;
                OnPropertyChanged(nameof(ChosenRecipe));
            }
        }
    }
}
