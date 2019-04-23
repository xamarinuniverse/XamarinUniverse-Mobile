using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUniverse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentPage : ContentPage
    {
        public CommentPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
                Icon = new FileImageSource { File = "comments.png" };
        }
    }
}