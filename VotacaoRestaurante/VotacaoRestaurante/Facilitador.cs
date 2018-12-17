﻿using System.Collections.Generic;

namespace VotacaoRestaurante
{
    using System;
    using System.Linq;

    public class Facilitador
    {
        public string Nome { get; }

        private Dictionary<Restaurante, int> restaurantesNumeroVotosDictionary;
        private Dictionary<string, bool> profissionalVotoUsadoDictionary;

        public Facilitador(string nomeFacilitador)
        {
            Nome = nomeFacilitador.ToUpper();
            restaurantesNumeroVotosDictionary = new Dictionary<Restaurante, int>();
            profissionalVotoUsadoDictionary = new Dictionary<string, bool>();
        }

        public bool AdicionarRestaurante(Restaurante restaurante)
        {
            return restaurantesNumeroVotosDictionary.TryAdd(restaurante, 0);
        }

        public bool AdicionarProfissional(string nomeProfissionalFaminto)
        {
            return profissionalVotoUsadoDictionary.TryAdd(nomeProfissionalFaminto.ToUpper(), false);
        }

        public void ReceberVoto(string nomeProfissionalFaminto, Restaurante restaurante)
        {
            if (ValidarProfissional(nomeProfissionalFaminto.ToUpper()) && ValidarRestaurante(restaurante))
            {
                AtualizarVotoProfissionalNoDia(nomeProfissionalFaminto.ToUpper());
                AdicionarVotoParaRestaurante(restaurante);
                return;
            }

            throw new InvalidOperationException();
        }

        private void AdicionarVotoParaRestaurante(Restaurante restaurante)
        {
            restaurantesNumeroVotosDictionary[restaurante] = restaurantesNumeroVotosDictionary[restaurante] + 1;
        }

        private void AtualizarVotoProfissionalNoDia(string nomeProfissionalFaminto)
        {
            profissionalVotoUsadoDictionary[nomeProfissionalFaminto] = true;
        }

        private bool ValidarRestaurante(Restaurante restaurante)
        {
            return restaurantesNumeroVotosDictionary.ContainsKey(restaurante);
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

        public Restaurante DeclararRestauranteVencedorDoDia()
        {
            Restaurante restauranteVencedor = RetornarRestauranteComMaisVotosNoDia();
            restaurantesNumeroVotosDictionary.Remove(restauranteVencedor);
            return restauranteVencedor;
        }

        private Restaurante RetornarRestauranteComMaisVotosNoDia()
        {
            return restaurantesNumeroVotosDictionary.Aggregate(
                    (restaurante1, restaurante2) =>
                        restaurante1.Value > restaurante2.Value ? restaurante1 : restaurante2)
                .Key;
        }
    }
}