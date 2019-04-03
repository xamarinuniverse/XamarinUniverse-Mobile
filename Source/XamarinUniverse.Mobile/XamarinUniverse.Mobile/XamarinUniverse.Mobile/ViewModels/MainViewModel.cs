using System;
using System.Collections.Generic;
using System.Text;
using XamarinUniverse.Mobile.Models;

namespace XamarinUniverse.Mobile.ViewModels
{

    public class MainViewModel
    {
        private static MainViewModel instance;

        public TokenResponse Token { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public MainViewModel()
        {
            instance = this;
           
        }

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
    }
}
