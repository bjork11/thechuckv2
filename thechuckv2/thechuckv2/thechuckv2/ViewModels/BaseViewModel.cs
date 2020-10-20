﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using thechuckv2.Services;

namespace thechuckv2.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        protected readonly IApiService _apiService;
        protected readonly INavigationService _navigationService;
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
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}