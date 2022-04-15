using BusnLogicTakenApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DALFakeUnitTest;
using System;

namespace BusnLogicUnitTest
{
    [TestClass]
    public class TaakTest
    {
        private readonly TaakContainer tc = new TaakContainer(new TaakFakeUTDAL());

        [TestMethod]
        public void ZoekSoftware()
        {
            // Arrange.
            Taak taak;
            // Act.
            taak = tc.FindById(1);
            // Assert.
            Assert.AreEqual("Software", taak.Naam);
            Assert.AreEqual(1, taak.Id);
        }
        public void TaakBestaatNiet()
        {
            // Arrange.
            // Act.
            // Assert.
            Assert.ThrowsException<Exception>(() => tc.FindById(2));
        }
    }
}