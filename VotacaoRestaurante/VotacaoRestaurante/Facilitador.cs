using System;
using System.Collections.Generic;
using System.Linq;

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
            ValidarRestauranteExisteNoCadastro(restaurante);

            restaurantes.Add(restaurante);
        }

        private void ValidarRestauranteExisteNoCadastro(Restaurante restaurante)
        {
            if (restaurantes.Count(restauranteNaLista => restauranteNaLista.Nome.Equals(restaurante.Nome)) > 0)
                throw new InvalidOperationException();
        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return restaurantes.Count;
        }
    }
}