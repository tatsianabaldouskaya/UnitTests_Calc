using NUnit.Framework;
using System.Threading;

namespace NUnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SubTests:BaseTest
    {
        [Test]
        [TestCase(5, 2)]
        public void SubTest(int firstNumber, int secondNumber)
        {
            Thread.Sleep(10000);
            Assert.AreEqual(firstNumber-secondNumber, calc.Sub(firstNumber, secondNumber), "Sub is incorrect");
        }

        [Test]
        [TestCase(2)]
        public void SubFromZeroPositiveNumberResultNegativeTest(int secondNumber)
        {
            Thread.Sleep(10000);
            Assert.IsTrue(calc.Sub(0, secondNumber)<0, "Sub is incorrect");
        }

        [Test]
        [TestCase(-2)]
        public void SubFromZeroNegativeNumberResultPositiveTest(int secondNumber)
        {
            Thread.Sleep(10000);
            Assert.IsTrue(calc.Sub(0, secondNumber)>0, "Sub is incorrect");
        }
    }
}
