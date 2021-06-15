using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class CosTests:BaseTest
    {
        [TestInitialize]
        public void TestInit()
        {
            System.Console.WriteLine("Starting Cos tests");
        }

        [TestCleanup]
        public void TearClean()
        {
            System.Console.WriteLine("Cos tests are finished");
        }

        [TestMethod]
        public void CosTest()
        {
            Assert.AreEqual(Math.Cos(30), calc.Cos(30), "Cos is incorrect");
        }
    }
}
