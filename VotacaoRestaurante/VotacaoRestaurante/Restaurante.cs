namespace VotacaoRestaurante
{
    public class Restaurante
    {
        public string Nome { get; }

        public Restaurante(string nomeRestaurante)
        {
            Nome = nomeRestaurante;
        }

        public override bool Equals(object restaurante)
        {
            Restaurante restauranteComparar = restaurante as Restaurante;
            return Nome.Equals(restauranteComparar.Nome);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
    }
}