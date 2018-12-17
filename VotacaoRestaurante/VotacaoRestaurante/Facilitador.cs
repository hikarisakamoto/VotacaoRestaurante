namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; }


        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador;
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            return true;
        }
    }
}