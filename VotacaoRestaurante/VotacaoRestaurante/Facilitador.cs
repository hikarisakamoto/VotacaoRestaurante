using System.Collections.Generic;

namespace VotacaoRestaurante
{
    using System;
    using System.Linq;

    public class Facilitador
    {
        public string Nome { get; }

        private Dictionary<string, int> restaurantesNumeroVotosDictionary;
        private HashSet<string> restaurantesJaVisitadosNaSemana;
        private Dictionary<string, bool> profissionalVotoUsadoDictionary;

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador.ToUpper();
            restaurantesNumeroVotosDictionary = new Dictionary<string, int>();
            profissionalVotoUsadoDictionary = new Dictionary<string, bool>();
            restaurantesJaVisitadosNaSemana = new HashSet<string>();
        }

        public bool AdicionarRestaurante(string nomeRestaurante)
        {
            return restaurantesNumeroVotosDictionary.TryAdd(nomeRestaurante.ToUpper(), 0);
        }

        public bool AdicionarProfissional(string nomeProfissionalFaminto)
        {
            return profissionalVotoUsadoDictionary.TryAdd(nomeProfissionalFaminto.ToUpper(), false);
        }

        public void ReceberVoto(string nomeProfissionalFaminto, string nomeRestaurante)
        {
            if (ValidarProfissional(nomeProfissionalFaminto.ToUpper()) && ValidarRestaurante(nomeRestaurante))
            {
                AtualizarVotoProfissionalNoDia(nomeProfissionalFaminto.ToUpper());
                AdicionarVotoParaRestaurante(nomeRestaurante);
                return;
            }

            throw new InvalidOperationException();
        }

        private void AdicionarVotoParaRestaurante(string nomeRestaurante)
        {
            restaurantesNumeroVotosDictionary[nomeRestaurante] = restaurantesNumeroVotosDictionary[nomeRestaurante] + 1;
        }

        private void AtualizarVotoProfissionalNoDia(string nomeProfissionalFaminto)
        {
            profissionalVotoUsadoDictionary[nomeProfissionalFaminto] = true;
        }

        private bool ValidarRestaurante(string nomeRestaurante)
        {
            return restaurantesNumeroVotosDictionary.ContainsKey(nomeRestaurante);
        }

        private bool ValidarProfissional(string nomeProfissionalFaminto)
        {
            return ValidarProfissionalExiste(nomeProfissionalFaminto)
                   && ValidaProfissionalEstaAptoVotarNoDia(nomeProfissionalFaminto);
        }

        private bool ValidarProfissionalExiste(string nomeProfissionalFaminto)
        {
            return profissionalVotoUsadoDictionary.ContainsKey(nomeProfissionalFaminto);
        }

        private bool ValidaProfissionalEstaAptoVotarNoDia(string nomeProfissionalFaminto)
        {
            return !profissionalVotoUsadoDictionary[nomeProfissionalFaminto];
        }

        public string DeclararRestauranteVencedorDoDia()
        {
            AtualizarVotosDosProfissionais();

            string restauranteVencedor = RetornarRestauranteComMaisVotosNoDia();
            restaurantesNumeroVotosDictionary.Remove(restauranteVencedor);
            restaurantesJaVisitadosNaSemana.Add(restauranteVencedor);
            return restauranteVencedor;
        }

        private void AtualizarVotosDosProfissionais()
        {
            foreach (string key in profissionalVotoUsadoDictionary.Keys.ToList())
            {
                profissionalVotoUsadoDictionary[key] = false;
            }
        }

        private string RetornarRestauranteComMaisVotosNoDia()
        {
            return restaurantesNumeroVotosDictionary.Aggregate(
                    (restaurante1, restaurante2) =>
                        restaurante1.Value > restaurante2.Value ? restaurante1 : restaurante2)
                .Key;
        }
    }
}