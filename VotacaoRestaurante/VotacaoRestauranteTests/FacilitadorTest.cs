using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTest
    {
        private ProfissionalFaminto _profissional;
        private ProfissionalFaminto _profissionalFaminto;
        private Facilitador _facilitador;
        private Restaurante _restaurante;
        private Restaurante _restaurante2;

        [TestInitialize]
        public void DevePrepararOsTestesParaOFacilitador()
        {
            _profissional = new ProfissionalFaminto("Hikari Sakamoto");
            _profissionalFaminto = new ProfissionalFaminto("Raphaela Fonseca");
            _facilitador = new Facilitador(_profissional);
            _restaurante = new Restaurante("Me Gusta");
            _restaurante2 = new Restaurante("Madero");

        }

        [TestMethod]
        public void DeveTestarCriarUmFacilitador()
        {
            Assert.AreEqual(_profissional, _facilitador.ProfissionalFacilitador);
        }

        [TestMethod]
        public void DeveTestarReceberUmRestauranteParaCadastro()
        {
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante);
            Assert.AreEqual(1, _facilitador.QuantidadeRestaurantesCadastrados());
        }

        [TestMethod]
        public void DeveTestarNaoPermitirCadastrarUmRestauranteJaCadastrado()
        {
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante);
            _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante2);
            Assert.ThrowsException<InvalidOperationException>(() => _facilitador.AdicionarNovoRestauranteParaVoto(_restaurante));
        }

        [TestMethod]
        public void DeveVotarEmUmRestauranteComSucesso()
        {
            Assert.AreEqual(true, _facilitador.ReceberVotoParaRestaurante(_profissionalFaminto, _restaurante));

        }
    }
}