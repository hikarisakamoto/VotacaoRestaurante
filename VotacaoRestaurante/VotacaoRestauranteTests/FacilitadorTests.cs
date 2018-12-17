using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    using System;

    [TestClass]
    public class FacilitadorTests
    {
        private Facilitador facilitador;
        private Restaurante meGusta;
        private Restaurante madero;
        [TestInitialize]
        public void DevePrepararOsTestesDoFacilitador()
        {
            meGusta = new Restaurante("Me Gusta");
            madero = new Restaurante("Madero");
            facilitador = new Facilitador("Hikari Sakamoto");
        }

        [TestMethod]
        public void DeveCriarUmNovoFacilitador()
        {
            Assert.AreEqual("HIKARI SAKAMOTO", facilitador.Nome);
        }


        [TestMethod]
        public void DeveAdicionarRestaurantesNovosParaVotoComSucesso()
        {
            Assert.IsTrue(facilitador.AdicionarRestaurante(meGusta));
            Assert.IsTrue(facilitador.AdicionarRestaurante(madero));
        }

        [TestMethod]
        public void NaoDevePermitirAdicionarRestaurantesComNomesIguaisParaVoto()
        {
            facilitador.AdicionarRestaurante(meGusta);
            facilitador.AdicionarRestaurante(madero);
            Assert.IsFalse(facilitador.AdicionarRestaurante(madero));
        }

        [TestMethod]
        public void DeveAdicionarProfissionaisFamintosDistintos()
        {
            Assert.IsTrue(facilitador.AdicionarProfissional("Pedro"));
            Assert.IsTrue(facilitador.AdicionarProfissional("Bruno"));
            Assert.IsFalse(facilitador.AdicionarProfissional("Pedro"));
        }

        [TestMethod]
        public void DevePermitirUmProfissionalFamintoFazerUmVotoParaUmRestauranteApenas()
        {
            facilitador.AdicionarProfissional("Pedro");
            facilitador.AdicionarRestaurante(meGusta);
            facilitador.ReceberVoto("PEDRO", meGusta);
            Assert.ThrowsException<InvalidOperationException>(() => facilitador.ReceberVoto("PEDRO", meGusta));
        }
    }
}