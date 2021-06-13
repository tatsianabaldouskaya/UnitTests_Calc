using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class IsNegativeTests
    {
        
        [TestMethod]
        [DataRow(-2)]
        public void IsNegativeTest(int number)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.isNegative(number));
        }

        [TestMethod]
        public void ZeroIsNotNegativeTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsFalse(calc.isNegative(0));
        }
    }
}
