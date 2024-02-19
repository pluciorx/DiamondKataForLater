using DiamondKata;

namespace DiamondTests
{
    [TestClass]
    public class DiamondGeneratorTests
    {
        [TestMethod]
        public void ShouldReturn1Line()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('A');
            
            Assert.AreEqual(1, resut.Count());
        }

        public void ShouldReturn6Lines()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('C');

            Assert.AreEqual(5, resut.Count());
        }

        [TestMethod]
        public void ShouldReturnLineWithOnlyA()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('A');

            Assert.AreEqual("A", resut[0]);

        }

        [TestMethod]
        public void ShouldReturnLineWithB()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('B');

            Assert.AreEqual(" A ", resut[0]);
            Assert.AreEqual("B B", resut[1]);
            Assert.AreEqual(" A ", resut[2]);

        }

        [TestMethod]
        public void ShouldReturnLineWithb()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('b');

            Assert.AreEqual(" a ", resut[0]);
            Assert.AreEqual("b b", resut[1]);
            Assert.AreEqual(" a ", resut[2]);

        }

        [TestMethod]
        public void ShouldReturnDiamondForAnyLetter()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('C');

            Assert.AreEqual("  A  ", resut[0]);
            Assert.AreEqual(" B B ", resut[1]);
            Assert.AreEqual("C   C", resut[2]);
            Assert.AreEqual(" B B ", resut[3]);
            Assert.AreEqual("  A  ", resut[4]);

        }

        [TestMethod]
        public void ShouldReturnDiamondForLetterD()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('D');
            
            
            Assert.AreEqual("   A   ", resut[0]);
            Assert.AreEqual("  B B  ", resut[1]);
            Assert.AreEqual(" C   C ", resut[2]);
            Assert.AreEqual("D     D", resut[3]);
            Assert.AreEqual(" C   C ", resut[4]);
            Assert.AreEqual("  B B  ", resut[5]);
            Assert.AreEqual("   A   ", resut[6]);

        }

    }
}
