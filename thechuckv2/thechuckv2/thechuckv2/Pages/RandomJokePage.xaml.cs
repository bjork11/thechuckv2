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
            await viewModel.GetRandomJokeAsync();
        }
    }
}