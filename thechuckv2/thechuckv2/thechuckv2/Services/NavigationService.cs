using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace thechuckv2.Services
{
    public class NavigationService : INavigationService 
    {
        private Page MainPage => Shell.Current;

        public async Task GoBack()
        {
            await MainPage.Navigation.PopAsync();
        }
    }
}
