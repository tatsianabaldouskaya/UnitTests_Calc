using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        [DataRow(0, -2)]
        public void MultiplyByZeroTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Multiply(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(6, 2)]
        public void MultiplyTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber * secondNumber, calc.Multiply(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(-3, -2)]
        public void MultiplyTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) > 0);
        }


        [TestMethod]
        [DataRow(5, -2)]
        public void MultiplyPositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) < 0);
        }


    }
}
