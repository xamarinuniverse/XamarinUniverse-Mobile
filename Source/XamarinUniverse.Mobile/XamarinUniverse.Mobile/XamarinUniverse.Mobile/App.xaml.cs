using Newtonsoft.Json;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniverse.Mobile.Helpers;
using XamarinUniverse.Mobile.Models;
using XamarinUniverse.Mobile.Services;
using XamarinUniverse.Mobile.ViewModels;
using XamarinUniverse.Mobile.Views;

namespace XamarinUniverse.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            if (Settings.IsRemember)
            {
                DependencyService.Register<MockDataStore>();
                var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
                if (token.Expiration > DateTime.Now)
                {
                    var mainViewModel = MainViewModel.GetInstance();
                    mainViewModel.Token = token;

                    MainPage = new AppShell();// MainPage();
                    return;
                }
            }

            MainPage = new LoginPage();
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
