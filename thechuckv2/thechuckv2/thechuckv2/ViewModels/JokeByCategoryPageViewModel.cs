using System.Windows.Input;
using Xamarin.Forms;
using thechuckv2.Dto;
using System.Threading.Tasks;

namespace thechuckv2.ViewModels
{
    class JokeByCategoryPageViewModel : BaseViewModel
    {
        private readonly string category;
        private JokeDto _jokeByCategory = null;
        public ICommand LoadJokeByCategoryCommand { get; }

        public JokeByCategoryPageViewModel(string category)
        {
            this.category = category;
            Title = category;

            LoadJokeByCategoryCommand = new Command(
                async () => await GetJokeByCategoryAsync(),
                () => !IsBusy);
        }

        public JokeDto JokeByCategory
        {
            get => _jokeByCategory;
            set
            {
                if (_jokeByCategory != value)
                {
                    _jokeByCategory = value;
                    OnPropertyChanged(nameof(JokeByCategory));
                }
            }
        }

        public async Task GetJokeByCategoryAsync()
        {
            try
            {
                IsBusy = true;
                JokeByCategory = await _apiService.GetJokeByCategory(category);
            }
            catch
            {
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
