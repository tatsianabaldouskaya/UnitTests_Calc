using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SumTests:BaseTest
    {
        [Test]
        [TestCase(3, 2)]
        public void AddPositiveNumbersTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber+secondNumber, calc.Add(firstNumber, secondNumber), "Sum is incorrect");
        }

        [Test]
        [TestCase(2)]
        public void AddToZeroTest(double secondNumber)
        {
            Assert.AreEqual(secondNumber, calc.Add(0.0, secondNumber), "Sum is incorrect");
        }

        [Test]
        [TestCase(-3, -2)]
        public void AddNegativeNumbersTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber+secondNumber, calc.Add(firstNumber, secondNumber), "Sum is incorrect");
        }
    }
}
