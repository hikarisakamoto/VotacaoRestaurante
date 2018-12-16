using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class RestauranteTest
    {
        private Restaurante restaurante;

        [TestInitialize]
        public void DevePrepararOsTestesParaORestaurante()
        {
            restaurante = new Restaurante("Me Gusta");
        }

        [TestMethod]
        public void DeveCriarUmNovoRestauranteParaVotacao()
        {
            Assert.AreEqual("Me Gusta", restaurante.Nome);
        }

        [TestMethod]
        public void DeveAdicionarUmVotoParaUmRestaurante()
        {
            restaurante.AdicionarVoto();
            restaurante.AdicionarVoto();
            Assert.AreEqual(2, restaurante.NumeroVotos);
        }
    }
}