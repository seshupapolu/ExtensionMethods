using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seshu.Playground.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seshu.Playground.UnitTests.ExtensionMethods_Test
{

    [TestClass]
    public class EnumerableExtensionsTests
    {
        [TestMethod]
        public void Join_Should_Return_Valid_String()
        {
            var listOfStrings = new List<string>
            {
                "Seshu",
                "Papolu"
            };


            var result= EnumerableExtensions.Join(listOfStrings,',');
            Assert.AreEqual("Seshu,Papolu", result);

        }
    }
}
