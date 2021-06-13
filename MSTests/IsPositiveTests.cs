using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class IsPositiveTests
    {

        [TestMethod]
        [DataRow(2)]
        public void IsPositiveTest(int number)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.isPositive(number));
        }

        [TestMethod]
        public void ZeroIsNotPositiveTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsFalse(calc.isPositive(0));
        }
    }
}
