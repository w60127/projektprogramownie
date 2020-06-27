using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testPolskosci()
        {   //arrange
            string testowaetykieta = "grzegorz brzęszczyszczykiewicz";

            //act

            bool test1 = new Form1().czyZawieraPolskieZnaki(testowaetykieta);

            //assert
            Assert.IsTrue(test1);

        }
    }
}
