namespace VotacaoRestaurante
{
    public class Restaurante
    {
        public string Nome { get; }

        public Restaurante(string nomeRestaurante)
        {
            Nome = nomeRestaurante;
        }

        public override bool Equals(object obj)
        {
            return true;
        }
    }
}