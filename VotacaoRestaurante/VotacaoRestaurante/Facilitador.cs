using System.Collections.Generic;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public ProfissionalFaminto ProfissionalFacilitador { get; }

        public Facilitador(ProfissionalFaminto profissional)
        {
            ProfissionalFacilitador = profissional;
        }

        public void AdicionarNovoRestauranteParaVoto(Restaurante restaurante)
        {
            List<Restaurante> restaurantes = new List<Restaurante> { restaurante };
        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return 1;
        }
    }
}