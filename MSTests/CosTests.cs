using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class CosTests
    {
        [TestInitialize]
        public void TestInit()
        {
            System.Console.WriteLine("Starting Sin tests");

        }

        [TestCleanup]
        public void TearClean()
        {
            System.Console.WriteLine("Sin tests are finished");
        }

        [TestMethod]
        public void CosTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(Math.Cos(30), calc.Cos(30));

        }
    }
}
