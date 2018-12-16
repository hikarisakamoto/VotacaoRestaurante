using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTest
    {
        private ProfissionalFaminto profissional;
        private Facilitador facilitador;
        private Restaurante restaurante;

        [TestInitialize]
        public void DevePrepararOsTestesParaOFacilitador()
        {
            profissional = new ProfissionalFaminto("Hikari Sakamoto");
            facilitador = new Facilitador(profissional);
            restaurante = new Restaurante("Me Gusta");

        }

        [TestMethod]
        public void DeveCriarUmFacilitador()
        {
            Assert.AreEqual(profissional, facilitador.ProfissionalFacilitador);
        }

        [TestMethod]
        public void DeveReceberUmRestauranteParaCadastro()
        {
            facilitador.AdicionarNovoRestauranteParaVoto(restaurante);
            Assert.AreEqual(1, facilitador.QuantidadeRestaurantesCadastrados());
        }

        [TestMethod]
        public void NaoDevePermitirCadastrarUmRestauranteJaCadastrado()
        {
            Assert.ThrowsException<InvalidOperationException>(() => facilitador.AdicionarNovoRestauranteParaVoto(restaurante));
        }


    }
}