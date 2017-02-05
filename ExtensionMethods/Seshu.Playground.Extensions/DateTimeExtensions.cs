using System;

namespace Seshu.Playground.Extensions
{
    //  <summary>
    /// DateTimeExtensions class contains the extension methods for  DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets the last date of the Month
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <returns>DateTime</returns>
        public static DateTime ToLastDateOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
    }

}
