using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem;

namespace Tests
{
    [TestClass]
    public class BracketGeneratorTest
    {
        [TestMethod]
        public void SampleLength2Test()
        {
            var writer = new WriterMock();
            var generator = new BracketGenerator(writer);
            generator.Gen(2, 0, 0, "");
            Assert.AreEqual("(())", writer.GetLine());
            Assert.AreEqual("()()", writer.GetLine());
        }

        [TestMethod]
        public void SampleLength3Test()
        {
            var writer = new WriterMock();
            var generator = new BracketGenerator(writer);
            generator.Gen(3, 0, 0, "");
            Assert.AreEqual("((()))", writer.GetLine());
            Assert.AreEqual("(()())", writer.GetLine());
            Assert.AreEqual("(())()", writer.GetLine());
            Assert.AreEqual("()(())", writer.GetLine());
            Assert.AreEqual("()()()", writer.GetLine());
        }
    }
}
