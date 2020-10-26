using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using thechuckv2.Services;
using System.Collections.ObjectModel;
using thechuckv2.Dto;
using System.Windows.Input;
using System.Threading.Tasks;

namespace thechuckv2.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        protected readonly IApiService _apiService;
        protected readonly INavigationService _navigationService;
        public ICommand AddFavoriteCommand;
        private JokeDto _joke;

        public ObservableCollection<JokeDto> UserFavoriteJokes = new ObservableCollection<JokeDto>();
        public BaseViewModel()
        {
            try
            {
                _apiService = DependencyService.Get<IApiService>();
                _navigationService = DependencyService.Get<INavigationService>();
            }
            catch
            {

            }

            //AddFavoriteCommand = new Command(
            //                    async () => await AddJokeToFavorites(_joke),
            //                    () => !IsBusy);
        }
        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                if (_isBusy != value)
                {
                    _isBusy = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Title
        {
            get;
            set;
        }

        public async Task AddJokeToFavorites(JokeDto joke)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
