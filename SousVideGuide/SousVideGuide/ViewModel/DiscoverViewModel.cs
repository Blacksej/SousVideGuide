using SousVideGuide.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SousVideGuide.ViewModel
{
    class DiscoverViewModel : BindableObject
    {
        RecipeRepository recipeRepository;

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

        public DiscoverViewModel()
        {
            recipeRepository = new RecipeRepository();
            Reload();
        }

        internal void Reload()
        {
            recipesList = new ObservableCollection<Recipe>(recipeRepository.GetRecipes());
        }
    }
}
