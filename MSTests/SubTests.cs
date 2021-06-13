using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SubTests
    {
        [TestMethod]
        [DataRow(5, 2)]
        public void SubTest(int firstNumber, int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber - secondNumber, calc.Sub(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(2)]
        public void SubFromZeroPositiveNumberResultNegativeTest(int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Sub(0, secondNumber) < 0);
        }

        [TestMethod]
        [DataRow(-2)]
        public void SubFromZeroNegativeNumberResultPositiveTest(int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Sub(0, secondNumber) > 0);
        }
    }
}
