using System.Collections.Generic;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public ProfissionalFaminto ProfissionalFacilitador { get; }
        private List<Restaurante> restaurantes;

        public Facilitador(ProfissionalFaminto profissional)
        {
            ProfissionalFacilitador = profissional;
            restaurantes = new List<Restaurante>();
        }

        public void AdicionarNovoRestauranteParaVoto(Restaurante restaurante)
        {
            restaurantes.Add(restaurante);
        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return restaurantes.Count;
        }
    }
}