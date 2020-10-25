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
            Title = "Chuck Norris FACTS";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.RandomJoke == null)
            {
                await viewModel.GetRandomJokeAsync();
            }
        }
    }
}