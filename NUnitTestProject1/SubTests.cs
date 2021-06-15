using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SubTests:BaseTest
    {
        [Test]
        [TestCase(5, 2)]
        public void SubTest(int firstNumber, int secondNumber)
        {
            Assert.AreEqual(firstNumber-secondNumber, calc.Sub(firstNumber, secondNumber), "Sub is incorrect");
        }

        [Test]
        [TestCase(2)]
        public void SubFromZeroPositiveNumberResultNegativeTest(int secondNumber)
        {
            Assert.IsTrue(calc.Sub(0, secondNumber)<0, "Sub is incorrect");
        }

        [Test]
        [TestCase(-2)]
        public void SubFromZeroNegativeNumberResultPositiveTest(int secondNumber)
        {
            Assert.IsTrue(calc.Sub(0, secondNumber)>0, "Sub is incorrect");
        }
    }
}
