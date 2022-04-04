using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    class DiscoverViewModel : BindableObject
    {

        RecipeRepository recipeRepository;

        private Recipe selectedRecipe;

        public Recipe SelectedRecipe
        {
            get { return selectedRecipe; }
            set 
            { 
                selectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }


        private ObservableCollection<RecipeViewModel> recipesList;

        public ObservableCollection<RecipeViewModel> RecipesList
        {
            get { return recipesList; }
            set
            {
                recipesList = value;
                OnPropertyChanged(nameof(RecipesList));
            }
        }

        public DiscoverViewModel()
        {
            recipeRepository = new RecipeRepository();
        }

        public void GetRecipe()
        {
            RecipesList = new ObservableCollection<RecipeViewModel>();
            foreach (var recipe in recipeRepository.GetRecipes())
            {
                RecipeViewModel recipeViewModel = new RecipeViewModel(recipe);
                RecipesList.Add(recipeViewModel);
            }
        }
    }
}
