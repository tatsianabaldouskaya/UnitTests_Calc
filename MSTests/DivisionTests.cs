using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class DivisionTests
    {

        [TestInitialize]
        public void TestInit()
        {
            System.Console.WriteLine("Starting Div tests");

        }

        [TestCleanup]
        public void TearClean()
        {
            System.Console.WriteLine("Div tests are finished");
        }

        [TestMethod]
        [DataRow(6, 3)]
        [DataRow(5, 10)]
        [DataRow(2.2, 2)]
        public void DivisionTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber / secondNumber, calc.Divide(firstNumber, secondNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividebyZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            calc.Divide(12, 0);
        }

        [TestMethod]
        [DataRow(-6, -3)]
        public void DivideTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) > 0);
        }


        [TestMethod]
        [DataRow(12, -3)]
        public void DividePositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) < 0);
        }


    }
}
