using System;
using System.Globalization;

namespace Fasetto.Word
{
    /// <summary>
    /// Takes in a date and converts it to a user-friendly message read time
    /// </summary>
    class TimeToReadTimeConverter : BaseValueConverter<TimeToReadTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is not read...
            if (time == DateTimeOffset.MinValue)
                return string.Empty; // Show nothing

            // If it is today...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                return $"Read {time.ToLocalTime().ToString("HH:mm")}"; // Return just the time

            // If it is this year...
            if (time.Date.Year == DateTimeOffset.UtcNow.Date.Year)
                return $"Read {time.ToLocalTime().ToString("HH:mm, dd. MMMM")}"; // Return time and date without the year

            // Otherwise, return a full date
            return $"Read {time.ToLocalTime().ToString("HH:mm, dd. MMMM yyyy")}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
