using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using WorkWithUnitTests;

namespace UnitTestForCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void unitTestFor()
        {
            
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void checkRegexExpression()
        {
            Regex expression = new Regex("[0-9]");
            int sum = 
        }
    }
}
