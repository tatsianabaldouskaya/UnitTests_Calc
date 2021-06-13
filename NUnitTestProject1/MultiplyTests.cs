using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        [TestCase(0, -2)]
        public void MultiplyByZeroTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Multiply(firstNumber, secondNumber));
        }

        [Test]
        [TestCase(6, 2)]
        public void MultiplyTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber*secondNumber, calc.Multiply(firstNumber, secondNumber));
        }

        [Test]
        [TestCase(-3, -2)]
        public void MultiplyTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) > 0);
        }


        [Test]
        [TestCase(5, -2)]
        public void MultiplyPositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) < 0);
        }


    }
}
