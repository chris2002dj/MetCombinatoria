using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n1 = 0, risultato = 1;

            long tot = EquazioniLibrary.CalcoliCombinatori.fattoriale01(n1);

            Assert.AreEqual(risultato, tot);
        }
    }
}
