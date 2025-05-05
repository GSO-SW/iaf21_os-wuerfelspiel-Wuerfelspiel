using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {

        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            //arrange 


            //act 
            Wuerfel w = new Wuerfel();

            //assert
            Assert.IsNotNull(w);
        }
        [TestMethod]
        public void Wuerfel_WuerfeltZahlEinsBisSechs()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int ergebnis = w.Wuerfeln();

            //Assert
            Assert.IsTrue(ergebnis >= 1);
            Assert.IsTrue(ergebnis <= 6);
        }
        [TestMethod]
        public void Wuerfel_WuerfeltNichtBeiGesichertemZustand()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int ergebnis = w.Wuerfeln();
            w.Gesichert = true;
            int ergebnis2 = w.Wuerfeln();

            Assert.AreEqual(ergebnis, ergebnis2);
        }
    }
}
