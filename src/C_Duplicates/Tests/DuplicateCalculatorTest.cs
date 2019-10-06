using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class DuplicateCalculatorTest
    {
        [TestMethod]
        public void SampleTest()
        {
            using (var reader = new ReaderStub(new[] { 2, 4, 8, 8, 8 }))
            using (var writer = new WriterMock())
            {
                var calculator = new DuplicateCalculator(reader, writer);
                calculator.WriteUnique(5);
                Assert.AreEqual(2, writer.GetNumber());
                Assert.AreEqual(4, writer.GetNumber());
                Assert.AreEqual(8, writer.GetNumber());
            }
        }

        [TestMethod]
        public void Sample2Test()
        {
            using (var reader = new ReaderStub(new[] { 2, 2, 2, 8, 8 }))
            using (var writer = new WriterMock())
            {
                var calculator = new DuplicateCalculator(reader, writer);
                calculator.WriteUnique(5);
                Assert.AreEqual(2, writer.GetNumber());
                Assert.AreEqual(8, writer.GetNumber());
            }
        }
    }
}
