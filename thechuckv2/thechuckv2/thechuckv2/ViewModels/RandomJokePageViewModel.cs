using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using thechuckv2.ViewModels;
using Xamarin.Forms;
using thechuckv2.Dto;
using System.Threading.Tasks;

namespace thechuckv2.ViewModels
{
    class RandomJokePageViewModel : BaseViewModel
    {
        private bool _isBusy = false;
        private JokeDto _randomJoke;
        public ICommand LoadRandomJokeCommand { get; }

        public RandomJokePageViewModel()
        {
            LoadRandomJokeCommand = new Command(
                async () => await GetRandomJokeAsync(),
                () => !IsBusy);
        }
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                    ((Command)LoadRandomJokeCommand).ChangeCanExecute();
                }
            }
        }

        public JokeDto RandomJoke
        {
            get => _randomJoke;
            set
            {
                if(_randomJoke != value)
                {
                    _randomJoke = value;
                    OnPropertyChanged(nameof(RandomJoke));
                }
            }
        }
        public async Task GetRandomJokeAsync()
        {
            try
            {
                IsBusy = true;
                _randomJoke = await _apiService.GetRandomJoke();
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
