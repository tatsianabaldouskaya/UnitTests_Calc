using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class PowTests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Starting Pow Tests");
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Pow Test is finished");
        }



        [Test]
        [TestCase(10, 1)]
        public void NumberInFirstPowTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(number, pow) == number);
        }


        [Test]
        [TestCase(5, 2)]
        public void PositiveNumberInPowTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(25, calc.Pow(number, pow));
        }

        [Test]
        [TestCase(-5, 2)]
        public void NegativeNumberInEvenPowIsPositiveTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(number, pow) > 0);
        }

        [Test]
        [TestCase(-5,3)]
        public void NegativeNumberInOddPowIsNegativeTest(int number, double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Pow(-5, pow) < 0);
        }


        [Test]
        [TestCase(3)]
        public void ZeroInPowTest(double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Pow(0, pow));
        }

        [Test]
        [TestCase(0)]
        public void NumberInZeroPowTest(double pow)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(1, calc.Pow(10, pow));
        }
    }
}