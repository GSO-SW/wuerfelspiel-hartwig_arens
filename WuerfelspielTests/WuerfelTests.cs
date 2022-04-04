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
            // Arrange
            Wuerfel w1 = new Wuerfel();
            // Act

            //Assert
            Assert.AreEqual(w1.anzahlSeiten, 6);
        }

        [TestMethod]
        public void D6Erstellen()
        {
            // Arrange
            int anzahlSeiten = 6;
            Wuerfel w2 = new Wuerfel(anzahlSeiten);
            // Act

            // Assert
            Assert.AreEqual(w2.AnzahlSeiten, anzahlSeiten);
        }

        [TestMethod]
        public void WuerfelWuerfeln()
        {
            // Arrange
            Wuerfel w3 = new Wuerfel();

            // Act
            int result = w3.Wuerfeln();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void WuerfelLetztesErgebnisAbrufen()
        {
            // Arrange
            Wuerfel w4 = new Wuerfel();
            // Act
            int result = w4.Wuerfeln();
            int result_save = w4.LetztesErgebnis;

            // Assert
            Assert.AreEqual(result, result_save);
        }
    }
}
