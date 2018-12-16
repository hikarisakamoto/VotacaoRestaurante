namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; private set; }

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador;
        }
    }
}