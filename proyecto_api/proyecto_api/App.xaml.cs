using proyecto_api.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyecto_api
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new principal());
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
