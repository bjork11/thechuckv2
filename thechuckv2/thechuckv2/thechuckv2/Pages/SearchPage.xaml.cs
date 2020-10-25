using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thechuckv2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thechuckv2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        private readonly SearchPageViewModel viewModel; 
        public SearchPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SearchPageViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            SearchText.Focus();
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await viewModel.Search(viewModel.Query);
        }
    }
}