using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seshu.Playground.Extensions;

namespace Seshu.Playground.UnitTests.ExtensionMethods_Test
{

    [TestClass]
    public class EnumerationExtensionsTest
    {
        [TestMethod]
        public void ToDescription_Should_Return_Valid_Description()
        {
            var desc = Status.CMPT.ToDescription();
            Assert.AreEqual(desc, "Completed");
        }

        public enum Status
        {
            [System.ComponentModel.Description("Draft")]
            DRFT = 0,
            [System.ComponentModel.Description("Pending")]
            PEND = 1,
            [System.ComponentModel.Description("Shipping")]
            SHP = 2,
            [System.ComponentModel.Description("Delivered")]
            DLV = 3,
            [System.ComponentModel.Description("Completed")]
            CMPT = 4
        }
    }
}
