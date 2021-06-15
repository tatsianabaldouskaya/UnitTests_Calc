using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class DivisionTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            System.Console.WriteLine("Starting Division tests");
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("Division tests are finished");
        }

        [Test]
        [TestCaseSource(nameof(DivideCases))]
        public void DivisionTest(double firstNumber, double secondNumber)
        {
            Assert.AreEqual(firstNumber / secondNumber, calc.Divide(firstNumber, secondNumber), "Div is incorrect");
        }

        static object[] DivideCases =
        {
           new object[] {12, 4},
           new object[] {15, 3},
           new object[] {20, 2}
        };
       
        [Test]
        public void DividebyZeroTest()
        {
            Assert.AreEqual(double.PositiveInfinity, calc.Divide(12, 0), "Div is incorrect");
        }

        [Test]
        [TestCase(-6, -3)]
        public void DivideTwoNegativeNumbersResultPositiveTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) > 0, "Div is incorrect");
        }

        [Test]
        [TestCase(12, -3)]
        public void DividePositiveByNegativeNumberResultNegativeTest(double firstNumber, double secondNumber)
        {
            Assert.IsTrue(calc.Divide(firstNumber, secondNumber) < 0, "Div is incorrect");
        }     
    }
}
