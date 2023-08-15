using ArranjosVetores;
using System;

namespace ExercicioContaBancaria {
    internal class Program {
        static void Main(string[] args) {
            //LerAlunos();
            LerProdutos();
        }

        static void LerProdutos() {
            Console.WriteLine("Digite a quantidade de produtos:");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[quantidadeProdutos];
            for (int i = 0; i < produtos.Length; i++) {
                Console.WriteLine($"Digite o nome {i + 1}º produto");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o preço {i + 1}º produto");
                double preco = double.Parse(Console.ReadLine());

                produtos[i] = new Produto(nome, preco);
            }

            double somaPrecoProdutos = 0;
            Console.WriteLine("\n\n");
            for (int i = 0; i < produtos.Length; i++) {
                somaPrecoProdutos += produtos[i].Preco;
            }
            double mediaAltura = somaPrecoProdutos / quantidadeProdutos;
            Console.WriteLine("A média de preço dos produtos é de" + mediaAltura.ToString("F2"));
        }

        static void LerAlunos() {
            Console.WriteLine("Digite a quantidade de alunos:");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            double[] alturaAlunos = new double[quantidadeAlunos];

            for (int i = 0; i < alturaAlunos.Length; i++) {
                Console.WriteLine($"Digite a altura do {i + 1}º aluno");
                alturaAlunos[i] = double.Parse(Console.ReadLine());
            }

            double somaAlturas = 0;
            Console.WriteLine("\n\n");
            for (int i = 0; i < alturaAlunos.Length; i++) {
                somaAlturas += alturaAlunos[i];
                Console.WriteLine($"A altura dos seus alunos são {alturaAlunos[i].ToString("F2")}");
            }
            double mediaAltura = somaAlturas / quantidadeAlunos;
            Console.WriteLine("A média de altura dos seus alunos é de" + mediaAltura.ToString("F2"));
        }
    }
}