using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void WuerfelErstellen()
        {
            Wuerfel w1 = new Wuerfel();
            Assert.IsNotNull(w1);
        }

        [TestMethod]
        public void D6Erstellen()
        {
            int anzahlSeiten = 6;
            Wuerfel w2 = new Wuerfel(anzahlSeiten);
            Assert.AreEqual(w2.AnzahlSeiten, anzahlSeiten);
        }
    }
}
