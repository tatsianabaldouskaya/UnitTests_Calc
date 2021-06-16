using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{
    [TestClass]
    public class DivisionTests:BaseTest
    {
        protected TestContext context;

        //public TestContext TestContext
        //{
        //    get { return context; }
        //    set { context = value; }
        //}

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Starting Div tests");
        }

        [TestCleanup]
        public void TearClean()
        {
            Console.WriteLine("Div tests are finished");
        }

        //[TestMethod]
        //[DeploymentItem("MSTests\\TestData.xlsx")]
        //[DataSource("MyExcelConn")]
        //public void DivisionTest()
        //{

        //    Assert.AreEqual(["dividend"] / context.DataRow["divider"], calc.Divide("", ""), "Div is incorrect");
        //}

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividebyZeroTest()
        {
            calc.Divide(12, 0);
        }

        [TestMethod]
        [DataRow(-6, -3)]
        public void DivideTwoNegativeNumbersResultPositiveTest(double dividend, double divider)
        {
            Assert.IsTrue(calc.Divide(dividend, divider) > 0, "Div is incorrect");
        }

        [TestMethod]
        [DataRow(12, -3)]
        public void DividePositiveByNegativeNumberResultNegativeTest(double dividend, double divider)
        {
            Assert.IsTrue(calc.Divide(dividend, divider) < 0, "Div is incorrect");
        }
    }
}
