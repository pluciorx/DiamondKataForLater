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
            Assert.AreEqual(" A ", resut[0]);

        }

        [TestMethod]
        public void ShouldReturnDiamond()
        {
            var sut = new DiamondGenerator();
            var resut = sut.GetDiamond('A');

            foreach (var item in resut)
                Console.WriteLine(item);

        }

    }
}
