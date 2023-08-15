using System;

namespace Estoque {
    internal class Program {
        static Produto Produto;

        static void Main(string[] args) {
            lerProduto();
            MobilizarProduto();
        }

        static void lerProduto() {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            Produto = new Produto(nome, preco);

            Produto produto2 = new Produto {
                Nome = nome,
            };
            Console.WriteLine(Produto);
        }

        static void MobilizarProduto() {
            Console.WriteLine("Qual a quantidade de produtos que você deseja adicionar no seu estoque?");
            int quantityAdd = int.Parse(Console.ReadLine());
            Produto.AdicionarProdutos(quantityAdd);
            Console.WriteLine(Produto);

            Console.WriteLine("Qual a quantidade de produtos que você deseja remover no seu estoque?");
            int quantityOdd = int.Parse(Console.ReadLine());
            Produto.RemoverProdutos(quantityOdd);
            Console.WriteLine(Produto);
        }

    }
}