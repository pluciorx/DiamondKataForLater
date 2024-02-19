using DiamondKata;

namespace DiamondTests
{
    [TestClass]
    public class InputValidatorTests
    {
        [TestMethod]
        public void SholdReturnFalseForInvalidInput()
        {
            var sut = new InputValidator();
            var result = sut.IsValidInput("3");
            var result2 = sut.IsValidInput("}");
            var result3 = sut.IsValidInput("Ab");
            var result4 = sut.IsValidInput("G");

            Assert.IsFalse(result);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
        }

        [TestMethod]
        public void SholdReturnTrueForValirInput()
        {
            var sut = new InputValidator();
            var result = sut.IsValidInput("A");
            var result2 = sut.IsValidInput("Z");

            Assert.IsTrue(result && result2);
            
        }
    }
}
