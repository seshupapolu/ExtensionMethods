using System;
using System.Globalization;

namespace Seshu.Playground.Extensions
{
    /// <summary>
    /// StringExtensions class contains the extension methods for  string
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Gets the string by in UTC format
        /// </summary>
        /// <param name="input">The input</param>
        /// <returns>string</returns>
        public static string ToUtcShortdateString(this string input, string format)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            string parsedDate = null;
            try
            {
                DateTime date;
                if (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    parsedDate = date.ToShortDateString();
            }
            catch
            {
                // ignored
            }
            return parsedDate;
        }
    }
}
