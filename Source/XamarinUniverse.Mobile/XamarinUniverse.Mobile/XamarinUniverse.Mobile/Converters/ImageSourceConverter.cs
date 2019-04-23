using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinUniverse.Mobile.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = value as string;
            if (string.IsNullOrEmpty(imagePath))
                return null;

            var resource = ImageSource.FromResource(imagePath);
            return resource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
