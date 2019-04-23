namespace XamarinUniverse.Mobile.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class ImageResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return ImageSource.FromResource(value.ToString());
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
