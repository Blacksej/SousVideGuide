using System;
using System.Collections.Generic;
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

                if(file == null)
                {
                    return;
                }

                SelectedImage.Text = file.FileName;
            }
            catch(Exception)
            {

            }
        }

        private void CreateRecipeClicked(object sender, EventArgs e)
        {
            //MessagingCenter.Subscribe<Page> 
            viewModel.CreateRecipe();
        }
    }
}