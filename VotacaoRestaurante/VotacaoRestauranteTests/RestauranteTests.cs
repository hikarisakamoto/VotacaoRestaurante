namespace VotacaoRestauranteTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VotacaoRestaurante;

    [TestClass]
    public class RestauranteTests
    {
        [TestMethod]
        public void DeveCriarUmNovoRestaurante()
        {
            Restaurante restaurante = new Restaurante("Me Gusta");
            Assert.AreEqual("Me Gusta", restaurante.Nome);
        }
    }
}