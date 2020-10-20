using System;
using thechuckv2.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using thechuckv2.Pages;

namespace thechuckv2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IApiService, ApiService>();
            DependencyService.Register<INavigationService, NavigationService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
