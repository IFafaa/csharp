using System;

namespace HotelSistema
{
    internal class Program {
        static void Main(string[] args) {
            LerQuartos();
            //LerHospede();
        }

        static void LerQuartos() {
            Quarto[] quartos = new Quarto[10];

            int quantidadeHospedes = 0;
            while (1 > quantidadeHospedes || quantidadeHospedes > 10) {
                Console.Write("Quantos quartos serão reservados? (Escolha um número de 1 a 10)");
                quantidadeHospedes = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantidadeHospedes; i++) {
                Console.WriteLine($"Reserva #{i + 1}:");

                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Email:");
                string email = Console.ReadLine();

                Console.Write("CPF:");
                string cpf = Console.ReadLine();

                int numeroQuarto = 0;
                while (1 > numeroQuarto || numeroQuarto > 10) {
                    Console.Write("Quarto: (Escolha um número de 1 a 10)");
                    numeroQuarto = int.Parse(Console.ReadLine());
                    if (quartos[numeroQuarto] != null) {
                        numeroQuarto = 0;
                        Console.WriteLine("Este quarto já foi reservado.");
                    }
                }

                Console.WriteLine("----------------------------------------------------");
                quartos[numeroQuarto] = new Quarto();
                quartos[numeroQuarto].Hospede = new Hospede(nome, email, cpf);
            }

            Console.WriteLine("Quartos reservados:");

            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine($"{i}: {quartos[i].Hospede.ToString()}");
                }
            }

        }

        /*static void LerHospede() {
            int quantidadeQuartos = 0;
            while (1 > quantidadeQuartos || quantidadeQuartos > 10) {
                Console.Write("Quantos quartos serão reservados? (Escolha um número de 1 a 10)");
                quantidadeQuartos = int.Parse(Console.ReadLine());
            }

            Hospede[] hospedes = new Hospede[quantidadeQuartos];

            for (int i = 0; i < quantidadeQuartos; i++) {
                Console.WriteLine($"Reserva #{i + 1}:");

                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Email:");
                string email = Console.ReadLine();

                int quarto = 0;
                while (1 > quarto || quarto > 10) {
                    Console.Write("Quarto: (Escolha um número de 1 a 10)");
                    quarto = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("----------------------------------------------------");
                hospedes[i] = new Hospede(nome, email, quarto);
            }

            Console.WriteLine("Quartos reservados:");
            for (int i = 0; i < hospedes.Length; i++) {
                Console.WriteLine(hospedes[i].ToString());
            }
        }
        */
    }
}