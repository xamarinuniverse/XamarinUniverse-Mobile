using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniverse.Mobile.Helpers;

namespace XamarinUniverse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.Error, Languages.Accept);

        }
    }
}