using System;
using System.Collections.Generic;
using System.Linq;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public ProfissionalFaminto ProfissionalFacilitador { get; }
        private List<Restaurante> _restaurantes;

        public Facilitador(ProfissionalFaminto profissional)
        {
            ProfissionalFacilitador = profissional;
            _restaurantes = new List<Restaurante>();
        }

        public void AdicionarNovoRestauranteParaVoto(Restaurante restaurante)
        {
            ValidarRestauranteExisteNoCadastro(restaurante);

            _restaurantes.Add(restaurante);
        }

        private void ValidarRestauranteExisteNoCadastro(Restaurante restaurante)
        {
            if (_restaurantes.Count(restauranteNaLista => restauranteNaLista.Nome.Equals(restaurante.Nome)) > 0)
                throw new InvalidOperationException();
        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return _restaurantes.Count;
        }


        public bool ReceberVotoParaRestaurante(ProfissionalFaminto profissionalFaminto, Restaurante restaurante)
        {
            return true;
        }
    }
}