﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUniverse.Mobile.Helpers
{
    using Interfaces;
    using Resources;
    using Xamarin.Forms;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Login => Resource.Login;

        public static string Accept => Resource.Accept;

        public static string Error => Resource.Error;

        public static string About => Resource.About;

        public static string Email => Resource.Email;

        public static string EmailPlaceHolder => Resource.EmailPlaceHolder;

        public static string Password => Resource.Password;

        public static string PasswordPlaceHolder => Resource.PasswordPlaceHolder;

        public static string Remember => Resource.Remember;
    }
}
