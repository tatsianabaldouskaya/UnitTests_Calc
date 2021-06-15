using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class IsNegativeTests:BaseTest
    {
       [Test]
       [TestCase(-2)]
       public void IsNegativeTest(int number)
       {
           Assert.IsTrue(calc.isNegative(number), "Number is not negative");
       }

        [Test]
        public void ZeroIsNotNegativeTest()
        {
            Assert.IsFalse(calc.isNegative(0), "Zero is negative");
        }
    }
}