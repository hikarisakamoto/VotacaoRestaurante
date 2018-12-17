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

        [TestMethod]
        public void DeveDeclararORestauranteGanhadorDoDia()
        {
            PrepararVotacaoRestaurante();

            Assert.IsTrue(meGusta.Equals(facilitador.DeclararRestauranteVencedorDoDia()));
        }

        [TestMethod]
        public void NaoPermitirQueUmRestauranteGanheDuasVezes()
        {
            PrepararVotacaoRestaurante();
            Assert.IsTrue(meGusta.Equals(facilitador.DeclararRestauranteVencedorDoDia()));
            Assert.IsTrue(madero.Equals(facilitador.DeclararRestauranteVencedorDoDia()));
        }

        private void PrepararVotacaoRestaurante()
        {
            facilitador.AdicionarProfissional("Pedro");
            facilitador.AdicionarProfissional("Bruno");
            facilitador.AdicionarProfissional("João");
            facilitador.AdicionarProfissional("Mário");
            facilitador.AdicionarProfissional("Lucas");

            facilitador.AdicionarRestaurante(meGusta);
            facilitador.AdicionarRestaurante(madero);

            facilitador.ReceberVoto("Pedro", meGusta);
            facilitador.ReceberVoto("Bruno", meGusta);
            facilitador.ReceberVoto("João", meGusta);
            facilitador.ReceberVoto("Lucas", madero);
            facilitador.ReceberVoto("Mário", madero);
        }
    }
}