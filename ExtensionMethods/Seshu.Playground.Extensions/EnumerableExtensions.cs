using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seshu.Playground.Extensions
{

    /// <summary>
    /// EnumerableExtensions class contains the extension methods for  IEnumerable<string/>
    /// </summary>
    public static class EnumerableExtensions
    {

        /// <summary>
        /// Gets the string by joining the string
        /// </summary>
        /// <param name="list">The input</param>
        /// <param name="seperator">The Seperator</param>
        /// <returns>string</returns>
        public static string Join(this IEnumerable<string> list, char seperator)
        {
            if (list == null || !list.Any()) return null;

            StringBuilder builder = new StringBuilder();
            foreach (string item in list)
            {
                builder.Append(item);
                builder.Append(seperator);
            }
            return builder.ToString().Substring(0, builder.Length - 1);
        }
    }

}
