using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SumTests:BaseTest
    {
        [TestMethod]
        [DataRow(3, 2)]
        public void AddPositiveNumbersTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber + secondNumber, calc.Add(firstNumber, secondNumber), "Sum is insorrect");
        }

        [TestMethod]
        [DataRow(2)]
        public void AddToZeroTest(double secondNumber)
        {
            Assert.AreEqual(secondNumber, calc.Add(0.0, secondNumber), "Sum is insorrect");
        }

        [TestMethod]
        [DataRow(-3, -2)]
        public void AddNegativeNumbersTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber + secondNumber, calc.Add(firstNumber, secondNumber), "Sum is insorrect");
        }
    }
}
