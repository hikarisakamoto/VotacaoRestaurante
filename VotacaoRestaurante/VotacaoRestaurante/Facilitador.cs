namespace VotacaoRestaurante
{
    using System.Collections.Generic;

    public class Facilitador
    {
        public string Nome { get; }


        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador;
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            throw new System.NotImplementedException();
        }
    }
}