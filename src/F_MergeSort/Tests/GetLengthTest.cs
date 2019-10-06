using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class GetLengthTest
    {

        [TestMethod]
        public void LonelyDigitTest()
        {
            var parsedDigits = Program.ParseDigits("1 45").ToArray();
            Assert.AreEqual(45, parsedDigits[0]);
        }

        [TestMethod]
        public void OneDigitLengthTest()
        {
            var parsedDigits = Program.ParseDigits("3 1 2 3").ToArray();
            Assert.AreEqual(1, parsedDigits[0]);
            Assert.AreEqual(2, parsedDigits[1]);
            Assert.AreEqual(3, parsedDigits[2]);
        }

        [TestMethod]
        public void TwoDigitLengthTest()
        {
            var parsedDigits = Program.ParseDigits("11 1 2 3 4 5 6 7 8 9 10 11").ToArray();
            Assert.AreEqual(1, parsedDigits[0]);
            Assert.AreEqual(2, parsedDigits[1]);
            Assert.AreEqual(3, parsedDigits[2]);
            Assert.AreEqual(4, parsedDigits[3]);
            Assert.AreEqual(5, parsedDigits[4]);
            Assert.AreEqual(6, parsedDigits[5]);
            Assert.AreEqual(7, parsedDigits[6]);
            Assert.AreEqual(8, parsedDigits[7]);
            Assert.AreEqual(9, parsedDigits[8]);
            Assert.AreEqual(10, parsedDigits[9]);
            Assert.AreEqual(11, parsedDigits[10]);
        }
    }
}
