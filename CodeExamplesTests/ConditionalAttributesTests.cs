using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class ConditionalAttributesTests
    {
        [TestMethod()]
        public void ConditionalAttributesTest()
        {
            ConditionalAttributes ConAttrib = new ConditionalAttributes();
#if DEBUG
            Assert.IsFalse(string.IsNullOrEmpty(ConAttrib.DebugMessage));
#else
            Assert.IsTrue(true);
#endif
        }
    }
}