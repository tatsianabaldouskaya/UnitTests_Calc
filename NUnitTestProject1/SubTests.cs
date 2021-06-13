using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SubTests
    {
        [Test]
        [TestCase(5, 2)]
        public void SubTest(int firstNumber, int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(firstNumber-secondNumber, calc.Sub(firstNumber, secondNumber));
        }

        [Test]
        [TestCase(2)]
        public void SubFromZeroPositiveNumberResultNegativeTest(int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Sub(0, secondNumber)<0);
        }

        [Test]
        [TestCase(-2)]
        public void SubFromZeroNegativeNumberResultPositiveTest(int secondNumber)
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.IsTrue(calc.Sub(0, secondNumber)>0);
        }
    }
}
