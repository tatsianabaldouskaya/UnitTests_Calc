using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class ABSTests:BaseTest
    {
        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Starting ABS tests");
        }

        [TestCleanup]
        public void TestClean()
        {
            Console.WriteLine("ABS tests are finished");
        }

        [TestMethod]
        [DataRow(-4)]
        public void ABSNegativeNumberTest(double negativeNumber)
        {
            Assert.AreEqual(-negativeNumber, calc.Abs(negativeNumber), "ABS is incorrect");
        }

        [TestMethod]
        [DataRow(4)]
        public void ABSPositiveNumberTest(double positiveNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(positiveNumber, calc.Abs(positiveNumber), "ABS is incorrect");
        }

        [TestMethod]
        public void ABSZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Abs(0), "ABS is incorrect");
        }
    }
}
