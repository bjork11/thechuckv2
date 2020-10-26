using System;
using thechuckv2.Dto;
using thechuckv2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thechuckv2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomJokePage : ContentPage
    {
        private readonly RandomJokePageViewModel viewModel;
        public RandomJokePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RandomJokePageViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.RandomJoke == null)
            {
                await viewModel.GetRandomJokeAsync();
            }
        }

        //private void Label_Double_Tapped(object sender, EventArgs e, JokeDto joke)
        //{
        //    viewModel.AddToFavorites(joke);
        //}
    }
}