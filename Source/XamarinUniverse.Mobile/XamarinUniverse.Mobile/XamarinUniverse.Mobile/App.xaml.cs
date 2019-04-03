using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniverse.Mobile.Services;
using XamarinUniverse.Mobile.Views;

namespace XamarinUniverse.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
