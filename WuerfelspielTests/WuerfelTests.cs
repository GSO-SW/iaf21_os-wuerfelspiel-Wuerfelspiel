using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
<<<<<<< HEAD
        public void Wuerfel_KannErstelltWerden()
        {
            //arrange 
            

            //act 
            Wuerfel w = new Wuerfel();

            //assert
            Assert.IsNotNull(w);
=======
        public void Wuerfel_WuerfeltZahlEinsBisSechs()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int ergebnis = w.Wuerfeln();

            //Assert
            Assert.IsTrue(ergebnis >= 1);
            Assert.IsTrue(ergebnis <= 6);
>>>>>>> 6d58e43534bdba0da8993fc9af02f77ef7c523df
        }
    }
}
