using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in an RGB string such as FF00FF and converts it to a brush
    /// </summary>
    public class StringRGBToBrushConverter : BaseValueConverter<StringRGBToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (new BrushConverter().ConvertFrom($"#{value}")) as SolidColorBrush;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
