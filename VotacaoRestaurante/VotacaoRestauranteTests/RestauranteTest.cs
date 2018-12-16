using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class RestauranteTest
    {
        [TestMethod]
        public void DeveCriarUmNovoRestauranteParaVotacao()
        {
            Restaurante restaurante = new Restaurante("Me Gusta");
            Assert.AreEqual("Me Gusta", restaurante.Nome);
        }
    }
}