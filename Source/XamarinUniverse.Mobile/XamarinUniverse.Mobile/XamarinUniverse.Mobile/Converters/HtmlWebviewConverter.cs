using System;
using System.Globalization;
using WordPressPCL.Models;
using Xamarin.Forms;
using XamarinUniverse.Mobile.Helpers;

namespace XamarinUniverse.Mobile.Converters
{
    public class HtmlWebviewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Post post)
                return new HtmlWebViewSource { Html = HtmlTools.WrapContent(post) };

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
