using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class IsNegativeTests:BaseTest
    {      
        [TestMethod]
        [DataRow(-2)]
        public void IsNegativeTest(int number)
        {
            Assert.IsTrue(calc.isNegative(number), "Number is not negative");
        }

        [TestMethod]
        public void ZeroIsNotNegativeTest()
        {
            Assert.IsFalse(calc.isNegative(0), "Zero is negative");
        }
    }
}
