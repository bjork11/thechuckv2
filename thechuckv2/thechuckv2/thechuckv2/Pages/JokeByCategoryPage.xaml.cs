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
    public partial class JokeByCategoryPage : ContentPage
    {
        private readonly JokeByCategoryPageViewModel viewModel;
        public JokeByCategoryPage(string category)
        { 
            InitializeComponent();
            BindingContext = viewModel = new JokeByCategoryPageViewModel(category);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await viewModel.GetJokeByCategoryAsync();

        }
    }
}