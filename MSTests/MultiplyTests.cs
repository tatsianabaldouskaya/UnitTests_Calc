using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class MultiplyTests:BaseTest
    {
        [TestMethod]
        [DataRow(0, -2)]
        public void MultiplyByZeroTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(0, calc.Multiply(firstNumber, secondNumber), "Multiplication is incorrect");
        }

        [TestMethod]
        [DataRow(6, 2)]
        public void MultiplyTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber * secondNumber, calc.Multiply(firstNumber, secondNumber), "Multiplication is incorrect");
        }

        [TestMethod]
        [DataRow(-3, -2)]
        public void MultiplyTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) > 0, "Multiplication is incorrect");
        }

        [TestMethod]
        [DataRow(5, -2)]
        public void MultiplyPositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) < 0, "Multiplication is incorrect");
        }
    }
}
