using System.Collections.Generic;

namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; }
        private Dictionary<Restaurante, int> restaurantesVotosDictionary;
        private Dictionary<string, bool> profissionalVotoDictionary;

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador.ToUpper();
            restaurantesVotosDictionary = new Dictionary<Restaurante, int>();
            profissionalVotoDictionary = new Dictionary<string, bool>();
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            return restaurantesVotosDictionary.TryAdd(restaurante, 0);
        }

        public bool AdicionarProfissional(string nomeProfissionalFaminto)
        {
            return profissionalVotoDictionary.TryAdd(nomeProfissionalFaminto.ToUpper(), false);
        }

        public bool ReceberVoto(string pedro, Restaurante meGusta)
        {
            return true;
        }
    }
}