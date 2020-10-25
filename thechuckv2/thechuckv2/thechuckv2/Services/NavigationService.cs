using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using thechuckv2.Pages;

namespace thechuckv2.Services
{
    public class NavigationService : INavigationService 
    {
        private Page MainPage => Shell.Current;

        //public async Task GoBack()
        //{
        //    await MainPage.Navigation.PopAsync();
        //}

        public async Task GoToJokeByCategoryPage(string category)
        {
            await MainPage.Navigation.PushAsync(new JokeByCategoryPage(category));
        }
    }
}
