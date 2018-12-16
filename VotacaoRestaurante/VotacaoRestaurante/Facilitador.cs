using System;
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
            if (restaurantes.Count == 0)
            {
                restaurantes.Add(restaurante);
            }
            else
            {
                throw new InvalidOperationException();
            }


        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return restaurantes.Count;
        }
    }
}