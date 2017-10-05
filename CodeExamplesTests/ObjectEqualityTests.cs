using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class ObjectEqualityTests
    {
        [TestMethod()]
        public void EqualsTestDifferent()
        {
            ObjectEquality obj1 = new ObjectEquality(1);
            ObjectEquality obj2 = new ObjectEquality(2);

            Assert.IsFalse(obj1.Equals(obj2));
        }

        [TestMethod()]
        public void EqualsTestSame()
        {
            ObjectEquality obj1 = new ObjectEquality(1);
            ObjectEquality obj2 = new ObjectEquality(1);

            Assert.IsTrue(obj1.Equals(obj2));
        }
    }
}