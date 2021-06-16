using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class MultiplyTests:BaseTest
    {
        [Test]
        [TestCase(0, -2)]
        public void MultiplyByZeroTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(0, calc.Multiply(firstNumber, secondNumber), "Multiplication is incorrect");
        }

        [Test]
        [TestCase(6, 2)]
        public void MultiplyTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber*secondNumber, calc.Multiply(firstNumber, secondNumber), "Multiplication is incorrect");
        }

        [Test]
        [TestCase(-3, -2)]
        public void MultiplyTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) > 0, "Multiplication is incorrect");
        }

        [Test]
        [TestCase(5, -2)]
        public void MultiplyPositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Multiply(firstNumber, secondNumber) < 0, "Multiplication is incorrect");
        }
    }
}
