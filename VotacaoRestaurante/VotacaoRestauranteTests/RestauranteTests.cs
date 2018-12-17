using System;
using System.Collections.Generic;

namespace VotacaoRestauranteTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VotacaoRestaurante;

    [TestClass]
    public class RestauranteTests
    {
        private Restaurante restaurante;    

        [TestInitialize]
        public void DevePrepararOsTestesParaORestaurante()
        {
            restaurante = new Restaurante("Me Gusta");
        }

        [TestMethod]
        public void DeveCriarUmNovoRestaurante()
        {
            Assert.AreEqual("ME GUSTA", restaurante.Nome);
        }

        [TestMethod]
        public void DeveTestarSeDoisRestaurantesSaoIguais()
        {
            Restaurante restaurante2 = new Restaurante("Me Gusta");
            Assert.IsTrue(restaurante.Equals(restaurante2));
            Assert.AreEqual(restaurante.GetHashCode(), restaurante2.GetHashCode());
        }
    }
}