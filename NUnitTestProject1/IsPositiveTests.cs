using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class IsPositiveTests:BaseTest
    {
        [Test]
        [TestCase(2)]
        public void IsPositiveTest(int number)
        {
            Assert.IsTrue(calc.isPositive(number), "Number is not positive");
        }

        [Test]
        public void ZeroIsNotPositiveTest()
        {
            Assert.IsFalse(calc.isPositive(0), "Zero is positive");
        }
    }
}