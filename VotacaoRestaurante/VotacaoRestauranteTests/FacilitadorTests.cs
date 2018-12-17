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
        public void DeveAdicionarRestaurantesNovosParaVotoComSucesso()
        {
            Restaurante meGusta = new Restaurante("Me Gusta");
            Restaurante madero = new Restaurante("Madero");

            Assert.IsTrue(facilitador.AdicionarRestaurante(meGusta));
            Assert.IsTrue(facilitador.AdicionarRestaurante(madero));
        }

    }
}