using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class IsPositiveTests:BaseTest
    {
        [TestMethod]
        [DataRow(2)]
        public void IsPositiveTest(int number)
        {
            Assert.IsTrue(calc.isPositive(number),"Number is not positive");
        }

        [TestMethod]
        public void ZeroIsNotPositiveTest()
        {
            Assert.IsFalse(calc.isPositive(0), "Zero is positive");
        }
    }
}
