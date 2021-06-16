using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CosTests:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Starting Cos tests");        
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Cos tests are finished");
        }

        [Test]
        public void CosTest()
        {
            Assert.AreEqual(Math.Cos(30), calc.Cos(30), "Cos is incorrect");
        }
    }
}