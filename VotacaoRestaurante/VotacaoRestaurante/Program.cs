using System;

namespace VotacaoRestaurante
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do facilitador: ");
            string nomeFacilitador = Console.ReadLine();

            Facilitador facilitador = new Facilitador(nomeFacilitador);
            facilitador.AdicionarRestaurante("Me Gusta");
            facilitador.AdicionarRestaurante("Madero");
            facilitador.AdicionarRestaurante("Japesca");
            facilitador.AdicionarRestaurante("Freio de Ouro");

            facilitador.AdicionarProfissional("Pedro");
            facilitador.AdicionarProfissional("Bruno");
            facilitador.AdicionarProfissional("Lucas");
            facilitador.AdicionarProfissional("João");

            Console.WriteLine($"{nomeFacilitador}, digite o nome do profissional: ");
            string nomeProfissional = Console.ReadLine();

            Console.WriteLine($"{nomeFacilitador}, digite o nome do restaurante que esse profissional deseja votar: ");
            string nomeRestaurante = Console.ReadLine();

            Console.WriteLine($"{nomeFacilitador}, deseja adicionar receber outro voto? [S/N]");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta.Equals("N"))
            {
                Console.WriteLine($"{nomeFacilitador}, deseja fechar a votação do dia?[S/N]");
                resposta = Console.ReadLine().ToUpper();
                if (resposta.Equals("S"))
                    Console.WriteLine("O restaurante vencedor do dia é " + facilitador.DeclararRestauranteVencedorDoDia());
            }
        }
    }
}