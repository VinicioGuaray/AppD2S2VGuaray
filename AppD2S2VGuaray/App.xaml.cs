using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppD2S2VGuaray
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login());
           // MainPage = new MainPage();
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
