namespace VotacaoRestaurante
{
    public class Restaurante
    {
        public string NomeRestaurante { get; }
        public int NumeroVotos { get; }
        public Restaurante(string nomeRestaurante)
        {
            NomeRestaurante = nomeRestaurante;
            NumeroVotos = 0;
        }
    }
}