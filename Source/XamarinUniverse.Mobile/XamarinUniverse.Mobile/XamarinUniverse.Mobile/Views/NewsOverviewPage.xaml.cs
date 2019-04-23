using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniverse.Mobile.ViewModels;

namespace XamarinUniverse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsOverviewPage : ContentPage
    {
        public NewsOverviewPage()
        {
            InitializeComponent();

            BindingContext = ServiceLocator.Current.GetInstance<NewsViewModel>();
        }
    }
}