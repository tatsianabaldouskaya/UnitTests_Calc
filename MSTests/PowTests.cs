using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class PowTests
    {
        [TestInitialize]
        public void TestInit()
        {
            System.Console.WriteLine("Starting Pow tests");

        }

        [TestCleanup]
        public void TearClean()
        {
            System.Console.WriteLine("Pow tests are finished");
        }



        [TestMethod]
        [DataRow(10, 1)]
        public void NumberInFirstPowTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(number, pow) == number);
        }


        [TestMethod]
        [DataRow(5, 2)]
        public void PositiveNumberInPowTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(25, calc.Pow(number, pow));
        }

        [TestMethod]
        [DataRow(-5, 2)]
        public void NegativeNumberInEvenPowIsPositiveTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(number, pow) > 0);
        }

        [TestMethod]
        [DataRow(-5, 3)]
        public void NegativeNumberInOddPowIsNegativeTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(-5, pow) < 0);
        }


        [TestMethod]
        [DataRow(3)]
        public void ZeroInPowTest(double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Pow(0, pow));
        }

        [TestMethod]
        [DataRow(0)]
        public void NumberInZeroPowTest(double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(1, calc.Pow(10, pow));
        }
    }
}
