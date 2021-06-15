using NUnit.Framework;
using System;
using CSharpCalculator;

namespace NUnitTestProject1
{
    [TestFixture]
    public class ABSTests:BaseTest
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
            Assert.AreEqual(-negativeNumber, calc.Abs(negativeNumber), "ABS is incorrect");
        }

        [Test]
        [TestCase(4)]
        public void ABSPositiveNumberTest(double positiveNumber)
        {
            Assert.AreEqual(positiveNumber, calc.Abs(positiveNumber), "ABS is incorrect");
        }

        [Test]
        public void ABSZeroTest()
        {
            Assert.AreEqual(0, calc.Abs(0), "ABS is incorrect");
        }
    }
}