using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class ImmutableTests
    {
        [TestMethod()]
        public void ImmutableTest()
        {
            Immutable mute = new Immutable("full", "half");
            Assert.AreEqual(mute.FullImmutable, "full");
        }
        
        [TestMethod()]
        public void InternalChangeTest()
        {
            string changeto = "halfish";
            Immutable mute = new Immutable("full", "half");
            mute.InternalChange(changeto);

            Assert.AreNotEqual(mute.HalfImmutable, "half");
        }
    }
}