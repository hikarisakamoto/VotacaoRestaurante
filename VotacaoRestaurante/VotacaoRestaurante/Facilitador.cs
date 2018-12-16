namespace VotacaoRestaurante
{
    public class Facilitador
    {
        public string Nome { get; }

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador;
        }

        public void AdicionarNovoRestaurante(string meGusta)
        {
            return;
        }

        public int QuantidadeRestaurantesCadastrados()
        {
            return 1;
        }
    }
}