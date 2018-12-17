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

        [TestMethod]
        public void DeveCriarUmNovoFacilitador()
        {
            Assert.AreEqual("Hikari Sakamoto", facilitador.Nome);
        }


        [TestMethod]
        public void DeveAdicionarUmNovoRestauranteParaVotoComSucesso()
        {
            Restaurante restaurante = new Restaurante("Me Gusta");
            Assert.IsTrue(facilitador.AdicionarRestaurante(restaurante));
        }

    }
}