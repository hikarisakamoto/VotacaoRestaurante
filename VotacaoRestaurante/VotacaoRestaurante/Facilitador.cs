using System.Collections.Generic;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; }
        private Dictionary<Restaurante, int> restaurantesVotosDictionary;

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador;
            restaurantesVotosDictionary = new Dictionary<Restaurante, int>();
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            return restaurantesVotosDictionary.TryAdd(restaurante, 0);
        }
    }
}