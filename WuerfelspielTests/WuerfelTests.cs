using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
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
    }
}
