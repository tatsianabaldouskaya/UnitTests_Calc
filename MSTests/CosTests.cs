using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace MSTests
{
    [TestClass]
    //[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.ClassLevel)]
    public class CosTests:BaseTest
    {
        [TestInitialize]
        public void TestInit()
        {
            Thread.Sleep(10000);
            System.Console.WriteLine("Starting Cos tests");
        }

        [TestCleanup]
        public void TearClean()
        {
            Thread.Sleep(10000);
            System.Console.WriteLine("Cos tests are finished");
        }

        [TestMethod]
        public void CosTest()
        {
            Thread.Sleep(10000);
            Assert.AreEqual(Math.Cos(30), calc.Cos(30), "Cos is incorrect");
        }
    }
}
