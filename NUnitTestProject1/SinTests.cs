using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SinTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SinTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(Math.Sin(60), calc.Sin("60"));

        }
    }
}