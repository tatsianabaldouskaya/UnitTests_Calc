using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class SubTests:BaseTest
    {
        [TestMethod]
        [DataRow(5, 2)]
        public void SubTest(int firstNumber, int secondNumber)
        {
            Assert.AreEqual(firstNumber - secondNumber, calc.Sub(firstNumber, secondNumber), "Sub is incorrect");
        }

        [TestMethod]
        [DataRow(2)]
        public void SubFromZeroPositiveNumberResultNegativeTest(int secondNumber)
        {
            Assert.IsTrue(calc.Sub(0, secondNumber) < 0, "Sub is not negative");
        }

        [TestMethod]
        [DataRow(-2)]
        public void SubFromZeroNegativeNumberResultPositiveTest(int secondNumber)
        {
            Assert.IsTrue(calc.Sub(0, secondNumber) > 0, "Sub is not positive");
        }
    }
}
