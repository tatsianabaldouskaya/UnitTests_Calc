using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharpCalculator;

namespace MSTests
{
    public class BaseTest
    {
        protected Calculator calc;

        [TestInitialize]
        public void BaseTestInit()
        {
            calc = new Calculator();
        }
        
        [TestCleanup]
        public void BaseTestClean()
        {
            calc = null;
        }
    }
}
