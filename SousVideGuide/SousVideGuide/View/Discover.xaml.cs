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
            RecipeViewModel recipeViewModel = obj as RecipeViewModel;
            ChosenRecipe chosenRecipe = new ChosenRecipe();
            (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = recipeViewModel;
            await Navigation.PushAsync(chosenRecipe);
        }
        public Discover()
        {
            InitializeComponent();
        }

        private void searchBarDiscoverTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = viewModel.RecipesList.Where(x => x.RecipeName.ToLower().Contains(searchBarDiscover.Text.ToLower()));
            recipesListCollection.ItemsSource = searchResult;
        }
    }
}