using System;
using System.ComponentModel;

namespace Seshu.Playground.Extensions
{
    /// <summary>
    /// EnumerationExtensions class contains the extension methods for  Enum
    /// </summary>
    public static class EnumerationExtensions
    {
        /// <summary>
        /// To the description.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>string</returns>
        public static string ToDescription(this Enum value)
        {
            var description = (DescriptionAttribute[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return description.Length > 0 ? description[0].Description : value.ToString();
        }
    }

}
