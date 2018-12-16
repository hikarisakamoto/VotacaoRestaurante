using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class ProfissionalFamintoTest
    {
        [TestMethod]
        public void DeveCriarUmNovoProfissionalFaminto()
        {
            ProfissionalFamintoTest profissionalFaminto = new ProfissionalFamintoTest("Hikari Sakamoto");
            Assert.AreEqual("Hikari Sakamoto", profissionalFaminto.Nome);
        }
    }
}