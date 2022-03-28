using SousVideGuide.Model;
using SousVideGuide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SousVideGuide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Discover : ContentPage
    {
        public Discover()
        {
            InitializeComponent();
        }

        private async void ShowRecipeTapped(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe("2L Water, 100g Salt, 50g Sugar, 10 Peppercorn, 5 Bay Leaves, 2kg Pork Shoulder, 4tbsp Brown Sugar, 2tbsp Paprika, 1tsp Chili Powder", "pulledpork.jpg", "Pulled Pork", "24", 73);
            RecipeViewModel recipeViewModel = new RecipeViewModel(recipe);
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
        }

        internal void Reload()
        {
            viewModel.Reload();
        }

        private async void ShowRecipeTapped2(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe("Rib-Eye Steak, Garlic Powder, Salt, Pepper", "ribeye.jpg", "Rib-Eye", "1.5", 56);
            RecipeViewModel recipeViewModel = new RecipeViewModel(recipe);
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
        }
    }
}