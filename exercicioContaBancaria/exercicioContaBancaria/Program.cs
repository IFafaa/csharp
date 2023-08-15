using exercicioContaBancaria;
using System;

namespace ExercicioContaBancaria
{
    internal class Program {
        static void Main(string[] args) {
            LerContaBancaria();
        }

        static void LerContaBancaria() {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveraDepositoInicial = char.Parse(Console.ReadLine());

            if(haveraDepositoInicial == 's' || haveraDepositoInicial == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta: \n" +  conta.ToString());

            Console.Write("\nEntre um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);
            Console.WriteLine("\nDados da conta atualizados: \n" + conta.ToString());

            Console.Write("\nEntre um valor para saque:");
            double saque = double.Parse(Console.ReadLine());
            conta.Sacar(saque);
            Console.WriteLine("\nDados da conta atualizados: \n" + conta.ToString());

        }
    }
}