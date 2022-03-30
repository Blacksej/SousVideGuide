using SousVideGuide.Model;
using SousVideGuide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SousVideGuide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Discover : ContentPage
    {
        public ICommand TappedCommand => new Command(Tapped);

        private async void Tapped(object obj)
        {
            RecipeViewModel recipeViewModel = new RecipeViewModel(obj as Recipe);
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
        }
        public Discover()
        {
            InitializeComponent();
        }

        private async void ShowRecipeTapped(object sender, EventArgs e)
        {
            RecipeViewModel recipeViewModel = new RecipeViewModel(viewModel.SelectedRecipe);
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
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