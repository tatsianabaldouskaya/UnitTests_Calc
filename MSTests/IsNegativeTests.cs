using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace MSTests
{
    [TestClass]
    public class IsNegativeTests:BaseTest
    {      
        [TestMethod]
        [DataRow(-2)]
        public void IsNegativeTest(int number)
        {
            Thread.Sleep(10000);
            Assert.IsTrue(calc.isNegative(number), "Number is not negative");
        }

        [TestMethod]
        public void ZeroIsNotNegativeTest()
        {
            Thread.Sleep(10000);
            Assert.IsFalse(calc.isNegative(0), "Zero is negative");
        }
    }
}
