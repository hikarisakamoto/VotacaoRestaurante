using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotacaoRestaurante;

namespace VotacaoRestauranteTests
{
    [TestClass]
    public class FacilitadorTests
    {
        /// <summary>
        /// Deve criar um novo facilitador.
        /// </summary>
        [TestMethod]
        public void DeveCriarUmNovoFacilitador()
        {
            Facilitador facilitador = new Facilitador("Hikari Sakamoto");
        }
    }
}