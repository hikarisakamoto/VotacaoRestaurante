using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTest
    {
        private ProfissionalFaminto profissional;
        private Facilitador facilitador;

        [TestInitialize]
        public void DevePrepararOsTestesParaOFacilitador()
        {
            profissional = new ProfissionalFaminto("Hikari Sakamoto");
            facilitador = new Facilitador(profissional);
        }

        [TestMethod]
        public void DeveCriarUmFacilitador()
        {
            Assert.AreEqual(profissional, facilitador.ProfissionalFacilitador);
        }

        [TestMethod]
        public void DeveReceberUmRestauranteParaCadastro()
        {
            Restaurante restaurante = new Restaurante("Me Gusta");
            facilitador.AdicionarNovoRestauranteParaVoto(restaurante);
            Assert.AreEqual(1, facilitador.QuantidadeRestaurantesCadastrados());
        }

    }
}