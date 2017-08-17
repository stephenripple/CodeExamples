using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class TuplesTests
    {
        [TestMethod()]
        public void FactoryExampleTest()
        {
            Assert.IsTrue(CodeExamples.Tuples.FactoryExample() > 0);
        }
    }
}