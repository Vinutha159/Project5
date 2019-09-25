using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simplepro3.Tests
{
    [TestClass]
    public class test4
    {
        [TestMethod]
        public void Add_numvalues()
        {
            
            //arrange
            int expected = 10;

            //act
            int actual = 5;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
