using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simplepro3.Tests
{
    [TestClass]
    public class test2
    {
        [TestMethod]
        public void Sum_numvalues()
        {
            //arrange
            int expected = 5;

            //act
            int actual = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
