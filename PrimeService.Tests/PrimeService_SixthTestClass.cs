using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_SixthTestClass
    {
        [TestCategory("Second category")]
        [TestCategory("First category")]
        [TestCategory("SimpleSimple")]
        [TestMethod]
        public void PassingTest()
        {
            Assert.Equals(4, Decimal.Add(2, 2));
        }

        [TestMethod]
        [Priority(2)]
        public void FailingTest()
        {
            Assert.Equals(5, Decimal.Add(2, 2));
        }

    }
}