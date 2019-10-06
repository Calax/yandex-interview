using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class MergerTest
    {

        [TestMethod]
        public void MergeTwoTest()
        {
            var lines = new[]
            {
                new Line(3, new byte[]{ 1, 5, 7 }),
                new Line(4, new byte[]{ 1, 6, 6, 8 })
            };

            var mergedDigits = Merger.Merge(lines);

            Assert.AreEqual(7, mergedDigits.Length);
            
            var digits = mergedDigits.Values.ToArray();
            Assert.AreEqual(1, digits[0]);
            Assert.AreEqual(1, digits[1]);
            Assert.AreEqual(5, digits[2]);
            Assert.AreEqual(6, digits[3]);
            Assert.AreEqual(6, digits[4]);
            Assert.AreEqual(7, digits[5]);
            Assert.AreEqual(8, digits[6]);
        }
    }
}
