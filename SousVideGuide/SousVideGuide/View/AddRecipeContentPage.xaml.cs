using SousVideGuide.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SousVideGuide.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddRecipeContentPage : ContentPage
    {
        public AddRecipeContentPage()
        {
            InitializeComponent();
        }

        private async void AddImageButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var file = await FilePicker.PickAsync();

                if (file == null)
                {
                    return;
                }

                SelectedImage.Text = file.FileName;
            }
            catch (Exception)
            {

            }
        }

        private async void CreateRecipeClicked(object sender, EventArgs e)
        {
            ChosenRecipe chosenRecipe = new ChosenRecipe();

            if (!(recipeNameEntry.Text == null || ingredientsEntry.Text == null || SelectedImage.Text == null 
                || recipeTimeEntry.Text == null || tempEntry.Text == null))
            {
                viewModel.CreateRecipe();
                bool answer = await DisplayAlert("Recipe was created", "Your recipe was created, would you like to view your recipe now?", "Yes", "No");

                if (answer)
                {
                    (chosenRecipe.BindingContext as ChosenRecipeViewModel).ChosenRecipe = new RecipeViewModel(viewModel.LastRecipe);
                    await Navigation.PushAsync(chosenRecipe);
                }
                else
                {
                    await Navigation.PopAsync();
                }
            }
            else
            {
                await DisplayAlert("Alert", "Please fill out all the textboxes", "OK");
            }
        }
    }
}