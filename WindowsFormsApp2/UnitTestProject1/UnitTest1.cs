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
            int licznik = testowaetykieta.Length;
          
            //act
         
            bool test1 = new Form1().testDlugosci(licznik);
            
            //assert
            Assert.IsTrue(test1);

        }
    }
}
