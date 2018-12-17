using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTests
    {
        private Facilitador facilitador;
        [TestInitialize]
        public void DevePrepararOsTestesDoFacilitador()
        {
            facilitador = new Facilitador("Hikari Sakamoto");
        }
        /// <summary>
        /// Deve criar um novo facilitador.
        /// </summary>
        [TestMethod]
        public void DeveCriarUmNovoFacilitador()
        {
            Assert.AreEqual("Hikari Sakamoto", facilitador.Nome);
        }
    }
}