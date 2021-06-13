using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        [DataRow(3, 2)]
        public void AddPositiveNumbersTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber + secondNumber, calc.Add(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(2)]
        public void AddToZeroTest(double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(secondNumber, calc.Add(0.0, secondNumber));
        }

        [TestMethod]
        [DataRow(-3, -2)]
        public void AddNegativeNumbersTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber + secondNumber, calc.Add(firstNumber, secondNumber));
        }


    }
}
