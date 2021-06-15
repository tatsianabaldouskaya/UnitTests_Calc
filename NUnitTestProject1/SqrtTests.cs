using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class SqrtTests:BaseTest
    {
        [Test]
        public void SqrtOfPositiveNumberTest()
        {
            object number = "4";
            Assert.AreEqual(2, calc.Sqrt(number), "Sqrt is incorrect");
        }

        [Test]
        public void SqrtOfZeroTest()
        {
            var calc = new CSharpCalculator.Calculator();
            Assert.AreEqual(0, calc.Sqrt(0), "Sqrt is incorrect");
        }

        [Test]
        public void SqrtOfNegativeNumberImpossibleTest()
        {
            Assert.Throws<NotFiniteNumberException>(() => calc.Sqrt(-4));
        }
    }
}