using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUniverse.Mobile.Helpers;
using XamarinUniverse.Mobile.Models;
using XamarinUniverse.Mobile.Services;
using XamarinUniverse.Mobile.Views;

namespace XamarinUniverse.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new Command(Login);

        // public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            Email = "sgrysoft@hotmail.com";
            Password = "123456";

            Title = Languages.Login;
                       
            //    MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //    {
            //        var newItem = item as Item;
            //        Items.Add(newItem);
            //        await DataStore.AddItemAsync(newItem);
            //    });
        }

        private async void Login()
        {
            if (IsBusy)
                return;


            if (string.IsNullOrEmpty(Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    Languages.EmailPlaceHolder,
                    Languages.Accept);
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    Languages.Error,
                    Languages.PasswordPlaceHolder,
                    Languages.Accept);
                return;
            }

            IsBusy = true;
            IsEnabled = false;

            var request = new TokenRequest
            {
                Password = Password,
                Username = Email
            };

            var url = Application.Current.Resources["UrlAPI"].ToString();
            var response = await ApiService.GetTokenAsync(
                url,
                "/Account",
                "/CreateToken",
                request);

            IsBusy = false;
            IsEnabled = true;

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Contraseña incorrecta.",
                    "Aceptar");
                return;
            }

            var token = (TokenResponse)response.Result;
            var mainViewModel = MainViewModel.GetInstance();

            mainViewModel.Token = token;
            Settings.IsRemember = true;

            Settings.Token = JsonConvert.SerializeObject(token);
            // Settings.User = JsonConvert.SerializeObject(user);

            Application.Current.MainPage = new MainPage();
        }

    }
}
