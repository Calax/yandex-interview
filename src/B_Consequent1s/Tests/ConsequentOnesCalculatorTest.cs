using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class ConsequentOnesCalculatorTest
    {
        [TestMethod]
        public void SampleTest()
        {
            var reader = new ReaderStub(new[] { "1", "0", "1", "0", "1" });
            var length = 0;
            using (var calculator = new ConsequentOnesCalculator(reader))
            {
                length = calculator.GetOnesLongestSequenceLength(5);
            }
            Assert.AreEqual(1, length);
        }

        [TestMethod]
        public void OnlyOneTest()
        {
            var reader = new ReaderStub(new[] { "1" });
            var length = 0;
            using (var calculator = new ConsequentOnesCalculator(reader))
            {
                length = calculator.GetOnesLongestSequenceLength(1);
            }
            Assert.AreEqual(1, length);
        }

        [TestMethod]
        public void OnlyZeroTest()
        {
            var reader = new ReaderStub(new[] { "0" });
            var length = 0;
            using (var calculator = new ConsequentOnesCalculator(reader))
            {
                length = calculator.GetOnesLongestSequenceLength(1);
            }
            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void LongestAtTheEndTest()
        {
            var reader = new ReaderStub(new[] { "0", "1", "0", "1", "1", "1" });
            var length = 0;
            using (var calculator = new ConsequentOnesCalculator(reader))
            {
                length = calculator.GetOnesLongestSequenceLength(6);
            }
            Assert.AreEqual(3, length);
        }

        [TestMethod]
        public void LongestAtTheBeginningTest()
        {
            var reader = new ReaderStub(new[] { "1", "1", "1", "0", "1", "1" });
            var length = 0;
            using (var calculator = new ConsequentOnesCalculator(reader))
            {
                length = calculator.GetOnesLongestSequenceLength(6);
            }
            Assert.AreEqual(3, length);
        }
    }
}
