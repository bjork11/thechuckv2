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
    public partial class StartPage : ContentPage
    {
        private readonly StartPageViewModel viewModel;
        public StartPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StartPageViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.Categories.Count == 0)
            {
                await viewModel.GetAllCategoriesAsync();
            }
        }

        private async void CategoryItemTapped(object sender, ItemTappedEventArgs e)
        {
            var category = e.Item as string;
            await viewModel.GotToCategoryAsync(category);
        }
    }
}