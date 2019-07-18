using System;
using System.Globalization;
using Xamarin.Forms;

namespace XConferenceApp.Converters
{
    public class BoolToShellItemTemplateBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var textColor = new Color(44.0 / 256, 45.0 / 256, 43.0 / 256);
            if (value is bool boolValue && boolValue)
            {
                textColor = new Color(229.0 / 256, 157.0 / 256, 0.0 / 256);
            }

            return textColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}