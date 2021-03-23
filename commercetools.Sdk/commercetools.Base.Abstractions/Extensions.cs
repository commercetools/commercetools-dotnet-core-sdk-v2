using System;
using System.Globalization;

namespace commercetools.Base
{
    public static class Extensions
    {
        public static DateTime AsDateTime(this string dateTimeString)
        {
            return DateTime.Parse(dateTimeString, CultureInfo.InvariantCulture);
        }
        public static DateTime AsDate(this string dateString)
        {
            return DateTime.Parse(dateString, CultureInfo.InvariantCulture);
        }
        public static TimeSpan AsTime(this string timeString)
        {
            return TimeSpan.Parse(timeString, CultureInfo.InvariantCulture);
        }
    }
}