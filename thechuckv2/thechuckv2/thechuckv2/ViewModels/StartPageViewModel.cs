using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using thechuckv2.Dto;
using Xamarin.Forms;
using thechuckv2.Services;

namespace thechuckv2.ViewModels
{
    class StartPageViewModel : BaseViewModel
    {
        public ObservableCollection<CategoriesDto> Categories { get; private set; } = new ObservableCollection<CategoriesDto>();

        //public StartPageViewModel()
        //{
        //    GetCategoriesCommand = new Command(
        //        async () => await GetAllCategoriesAsync());
        //}
    }
}
