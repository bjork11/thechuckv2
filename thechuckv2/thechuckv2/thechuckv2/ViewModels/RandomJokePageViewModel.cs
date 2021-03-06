﻿using System;
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
        private JokeDto _randomJoke;
        public ICommand LoadRandomJokeCommand { get; }

        public RandomJokePageViewModel()
        {
            Title = "Chuck Norris FACTS";

            LoadRandomJokeCommand = new Command(
                async () => await GetRandomJokeAsync(),
                () => !IsBusy);
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
                RandomJoke = await _apiService.GetRandomJoke();
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
