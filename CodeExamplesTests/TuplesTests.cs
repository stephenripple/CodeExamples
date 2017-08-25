using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class TuplesTests
    {
        [TestMethod()]
        public void TuplesExampleTest()
        {
            Assert.IsTrue(Tuples.TupleExample() > 0);
        }
    }
}