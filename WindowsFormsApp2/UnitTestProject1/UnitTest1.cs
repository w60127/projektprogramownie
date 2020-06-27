using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
namespace testy
{
    [TestClass]
    public class testywprowadzania
    {
        [TestMethod]
        public void testMaksymalnejDługości()
        {   //arrange
            string testowaetykieta = "grzegorz brzęszczyszczykiewicz";
            
            bool wynik = false;
            //act
            
            if (testowaetykieta.Length < 32)
            {
                wynik = true;
            };

            //assert
            Assert.IsTrue(wynik);

        }
    }
}
