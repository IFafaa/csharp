using System;
using System.Collections.Generic;

namespace FuncionariosControleSistema
{
    internal class Program {
        static void Main(string[] args) {
            LerFuncionarios();
        }

        static void LerFuncionarios() {
            Console.Write("Quantos funcionários serão cadastrados?");
            int quantidadeFunc = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < quantidadeFunc; i++) {
                Console.WriteLine($"Funcionario #{i + 1}:");

                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Salário:");
                double salario = double.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Digite o ID do funcionário que recebera o aumento: ");
            int funcId = int.Parse(Console.ReadLine());

            Funcionario funcionarioSelected = funcionarios.Find((f) => f.Id == funcId);
            if ( funcionarioSelected != null) {
                Console.Write("Digite a porcentagem do aumento? ");
                double percent = double.Parse(Console.ReadLine());
                funcionarioSelected.aumentarSalario(percent);
            }
            else{
                Console.WriteLine("Não foi possivel encontrar um funcionário com esse ID");
            }

            Console.WriteLine("\n\n-----------------");
            Console.WriteLine("\nLista de funcionários:");
            funcionarios.ForEach(x => {
                Console.WriteLine(x.ToString());
            });
        }
    }
}