using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seshu.Playground.Extensions;

namespace Seshu.Playground.UnitTests.ExtensionMethods_Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ToUtcShortdateString_Should_Return_Valid_Date()
        {
            string utcDateFormat = "ddd MMM dd HH:mm:ss UTC yyyy";
            var date = StringExtensions.ToUtcShortdateString("Sun Feb 10 14:07:00 UTC 2013", utcDateFormat);
            Assert.AreEqual("2/10/2013", date);

        }

    }
}
