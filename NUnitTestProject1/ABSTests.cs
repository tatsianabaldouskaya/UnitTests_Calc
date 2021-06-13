using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class ABSTests
    {           
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Starting ABS tests");  
           
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("ABS tests are finished");
        }


        [Test]
        [TestCase(-4)]
        public void ABSNegativeNumberTest(double negativeNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(-negativeNumber, calc.Abs(negativeNumber));

        }

        [Test]
        [TestCase(4)]
        public void ABSPositiveNumberTest(double positiveNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(positiveNumber, calc.Abs(positiveNumber));
        }

        [Test]
        public void ABSZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Abs(0));

        }

    }
}