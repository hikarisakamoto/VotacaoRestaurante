namespace VotacaoRestaurante
{
    public class Restaurante
    {
        public string Nome { get; }
        public int NumeroVotos { get; }
        public Restaurante(string nome)
        {
            Nome = nome;
            NumeroVotos = 0;
        }
    }
}