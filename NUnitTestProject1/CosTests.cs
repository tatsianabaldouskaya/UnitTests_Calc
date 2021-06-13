using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class CosTests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Starting Sin tests");
            
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Sin tests are finished");
        }

        [Test]
        public void CosTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(Math.Cos(30), calc.Cos(30));

        }
    }
}