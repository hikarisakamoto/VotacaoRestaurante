using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTest
    {
        [TestMethod]
        public void DeveCriarUmFacilitador()
        {
            ProfissionalFaminto profissional = new ProfissionalFaminto("Hikari Sakamoto");

            Facilitador facilitador = new Facilitador(profissional);
            Assert.AreEqual(profissional, facilitador.ProfissionalFacilitador);
        }

    }
}