using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace MSTests
{
    [TestClass]
    //[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.ClassLevel)]

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
            Thread.Sleep(10000);
            Assert.AreEqual(-negativeNumber, calc.Abs(negativeNumber), "ABS is incorrect");
        }

        [TestMethod]
        [DataRow(4)]
        public void ABSPositiveNumberTest(double positiveNumber)
        {
            Thread.Sleep(10000);
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(positiveNumber, calc.Abs(positiveNumber), "ABS is incorrect");
        }

        [TestMethod]
        public void ABSZeroTest()
        {
            Thread.Sleep(10000);
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Abs(0), "ABS is incorrect");
        }
    }
}
