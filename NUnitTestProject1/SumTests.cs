using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SumTests
    {
        [Test]
        [TestCase(3, 2)]
        public void AddPositiveNumbersTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber+secondNumber, calc.Add(firstNumber, secondNumber));
        }

        [Test]
        [TestCase(2)]
        public void AddToZeroTest(double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(secondNumber, calc.Add(0.0, secondNumber));
        }

        [Test]
        [TestCase(-3, -2)]
        public void AddNegativeNumbersTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber+secondNumber, calc.Add(firstNumber, secondNumber));
        }


    }
}
