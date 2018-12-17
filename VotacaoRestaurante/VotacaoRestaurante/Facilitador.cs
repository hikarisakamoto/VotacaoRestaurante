using System.Collections.Generic;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; }
        private Dictionary<Restaurante, int> restaurantesVotosDictionary;

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador.ToUpper();
            restaurantesVotosDictionary = new Dictionary<Restaurante, int>();
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            return restaurantesVotosDictionary.TryAdd(restaurante, 0);
        }

        public bool AdicionarProfissional(string nomeProfissionalFaminto)
        {
            throw new System.NotImplementedException();
        }
    }
}