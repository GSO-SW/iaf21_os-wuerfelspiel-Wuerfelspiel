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
    }
}
