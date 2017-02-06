using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seshu.Playground.Extensions;
using System;

namespace Seshu.Playground.UnitTests.ExtensionMethods_Test
{
    [TestClass]
    public class DateTimeExtensionsTest
    {
        [TestMethod]
        public void ToLastDateOfMonth_Should_Return_Valid_Date()
        {
            var dateTime = new DateTime(2016, 02, 05);
            var result = dateTime.ToLastDateOfMonth();
            Assert.AreEqual(result, new DateTime(2016, 02, 29));
        }


        [TestMethod]
        public void ToStartDateOfMonth_Should_Return_Valid_Date()
        {
            var dateTime = new DateTime(2016, 02, 22);
            var result = dateTime.ToStartDateOfMonth();
            Assert.AreEqual(result, new DateTime(2016, 02, 01));
        }

    }
}
