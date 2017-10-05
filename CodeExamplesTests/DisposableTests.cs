using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class DisposableTests
    {
        [TestMethod()]
        public void DisposeTest()
        {
            Disposable disposableObj;
            //The using pattern makes sure disposable is called at the end of the code block
            using (disposableObj = new Disposable())
            {
                if (disposableObj.toDisposeConnection == null)
                {
                    Assert.Fail();
                }
            }

            Assert.IsTrue(disposableObj.Disposed);
        }
    }
}