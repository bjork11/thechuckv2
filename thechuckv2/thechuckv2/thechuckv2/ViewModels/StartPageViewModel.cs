using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using thechuckv2.Dto;
using Xamarin.Forms;
using thechuckv2.Services;
using System.Windows.Input;
using System.Reflection;
using System.Threading.Tasks;

namespace thechuckv2.ViewModels
{
    class StartPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> Categories { get; private set; } = new ObservableCollection<string>();
        public ICommand GetCategoriesCommand { get; }
        public StartPageViewModel()
        {
            GetCategoriesCommand = new Command(
                async () => await GetAllCategoriesAsync(),
                () => !IsBusy);
        }

        public async Task GetAllCategoriesAsync()
        {
            Categories.Clear();

            IsBusy = true;
            var categories = await _apiService.GetAllCategories();

            foreach(var category in categories)
            {
                Categories.Add(category);
            }

            IsBusy = false;
        }
    }
}
