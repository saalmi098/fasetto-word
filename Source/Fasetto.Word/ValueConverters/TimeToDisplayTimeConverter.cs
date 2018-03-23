using System;
using System.Globalization;

namespace Fasetto.Word
{
    /// <summary>
    /// Takes in a date and converts it to a user-friendly time
    /// </summary>
    class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                return time.ToLocalTime().ToString("HH:mm"); // Return just the time

            // If it is this year...
            if (time.Date.Year == DateTimeOffset.UtcNow.Date.Year)
                return time.ToLocalTime().ToString("HH:mm, dd. MMMM"); // Return time and date without the year

            // Otherwise, return a full date
            return time.ToLocalTime().ToString("HH:mm, dd. MMMM yyyy");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
