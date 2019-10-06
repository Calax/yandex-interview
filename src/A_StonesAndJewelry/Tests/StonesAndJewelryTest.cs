using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class StonesAndJewelryTest
    {
        [TestMethod]
        public void SampleTest()
        {
            var ans = StonesAndJewelry.CalculateJewelry("aabbccd", "ab");
            Assert.AreEqual(4, ans);
        }
    }
}
