using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTest
    {
        private ProfissionalFaminto _profissional;
        private Facilitador _facilitador;
        private Restaurante _restaurante;
        private Restaurante _restaurante2;

        [TestInitialize]
        public void DevePrepararOsTestesParaOFacilitador()
        {
            _profissional = new ProfissionalFaminto("Hikari Sakamoto");
            _facilitador = new Facilitador(_profissional);
            _restaurante = new Restaurante("Me Gusta");
            _restaurante2 = new Restaurante("Madero");

        }

        [TestMethod]
        public void DeveCriarUmFacilitador()
        {
            Assert.AreEqual(_profissional, _facilitador.ProfissionalFacilitador);
        }

        [TestMethod]
        public void DeveReceberUmRestauranteParaCadastro()
        {
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante);
            Assert.AreEqual(1, _facilitador.QuantidadeRestaurantesCadastrados());
        }

        [TestMethod]
        public void NaoDevePermitirCadastrarUmRestauranteJaCadastrado()
        {
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante);
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante2);
            Assert.ThrowsException<InvalidOperationException>(() => _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante));
        }


    }
}