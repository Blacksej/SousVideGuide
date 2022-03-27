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
            Recipe recipe = new Recipe("- Pork Shoulder, - Salt, - Sugar, - Water", "pulledpork.jpg", "Pulled Pork");
            RecipeViewModel recipeViewModel = new RecipeViewModel(recipe);
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
        }
    }
}