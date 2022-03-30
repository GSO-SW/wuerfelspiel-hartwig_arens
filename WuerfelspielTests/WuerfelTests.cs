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
    }
}
