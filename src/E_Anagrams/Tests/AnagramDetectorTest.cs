using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class AnagramDetectorTest
    {
        [TestMethod]
        public void Sample1Test()
        {
            Assert.IsTrue(AnagramDetector.AreAnagrams("qiu", "iuq"));
        }

        [TestMethod]
        public void Sample2Test()
        {
            Assert.IsFalse(AnagramDetector.AreAnagrams("zprl", "zprc"));
        }
    }
}
