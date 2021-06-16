using NUnit.Framework;
using System;
using System.Threading;

namespace NUnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SqrtTests:BaseTest
    {
        [Test]
        public void SqrtOfPositiveNumberTest()
        {
            Thread.Sleep(10000);
            object number = "4";
            Assert.AreEqual(2, calc.Sqrt(number), "Sqrt is incorrect");
        }

        [Test]
        public void SqrtOfZeroTest()
        {
            Thread.Sleep(10000);
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Sqrt(0), "Sqrt is incorrect");
        }

        [Test]
        public void SqrtOfNegativeNumberImpossibleTest()
        {
            Thread.Sleep(10000);
            Assert.Throws<NotFiniteNumberException>(() => calc.Sqrt(-4));
        }
    }
}