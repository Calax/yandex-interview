using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class ParseDigitsTest
    {
        [TestMethod]
        public void OneDigitLengthTest()
        {
            Assert.AreEqual(3, Program.GetLength("3 1 2 3"));
        }

        [TestMethod]
        public void TwoDigitLengthTest()
        {
            Assert.AreEqual(11, Program.GetLength("11 1 2 3 4 5 6 7 8 9 10 11"));
        }
    }
}
