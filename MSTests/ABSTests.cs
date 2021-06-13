using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class ABSTests
    {
        [TestInitialize]
        public void TestInit()
        {
            System.Console.WriteLine("Starting ABS tests");

        }

        [TestCleanup]
        public void TestClean()
        {
            System.Console.WriteLine("ABS tests are finished");
        }


        [TestMethod]
        [DataRow(-4)]
        public void ABSNegativeNumberTest(double negativeNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(-negativeNumber, calc.Abs(negativeNumber));

        }

        [TestMethod]
        [DataRow(4)]
        public void ABSPositiveNumberTest(double positiveNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(positiveNumber, calc.Abs(positiveNumber));
        }

        [TestMethod]
        public void ABSZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Abs(0));

        }
    }
}
