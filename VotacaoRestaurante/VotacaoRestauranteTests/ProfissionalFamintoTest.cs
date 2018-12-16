using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class ProfissionalFamintoTest
    {
        [TestMethod]
        public void DeveCriarUmNovoProfissionalFaminto()
        {
            ProfissionalFaminto profissionalFaminto = new ProfissionalFaminto("Hikari Sakamoto");
            Assert.AreEqual("Hikari Sakamoto", profissionalFaminto.Nome);
        }
    }
}