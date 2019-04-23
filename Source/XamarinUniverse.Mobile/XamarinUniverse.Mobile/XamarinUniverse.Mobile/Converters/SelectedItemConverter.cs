namespace XamarinUniverse.Mobile.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class SelectedItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is SelectedItemChangedEventArgs eventArgs))
                return null;

            return eventArgs.SelectedItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
