namespace VotacaoRestaurante
{
    public class Restaurante
    {
        public string Nome { get; }
        public int NumeroVotos { get; private set; }

        public Restaurante(string nome)
        {
            Nome = nome;
            NumeroVotos = 0;
        }

        public void AdicionarVoto()
        {
            NumeroVotos++;
        }
    }
}