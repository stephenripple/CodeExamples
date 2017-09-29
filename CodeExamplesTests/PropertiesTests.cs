using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class PropertiesTests
    {
        [TestMethod()]
        public void PropertiesExampleTest()
        {
            Properties _proptest = new Properties();
            try
            {
                _proptest.PublicVariable = string.Empty;
                Assert.Fail("Validation for PublicVariable has failed");
            }
            catch (ArgumentException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentException));
            }
        }

        [TestMethod()]
        public void PropertiesIndexerExampleTest()
        {
            Properties _proptest = new Properties();
            var result = _proptest[1];
            Assert.IsTrue(result == 1);
        }
    }
}