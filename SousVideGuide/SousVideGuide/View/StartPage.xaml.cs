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
    public partial class StartPage : TabbedPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private async void AddRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipeContentPage());
        }

        private void DiscoverPageAppearing(object sender, EventArgs e)
        {
            DiscoverViewModel discoverViewModel = (discoverPage.BindingContext as DiscoverViewModel);
            discoverViewModel.GetRecipe();
        }
    }
}