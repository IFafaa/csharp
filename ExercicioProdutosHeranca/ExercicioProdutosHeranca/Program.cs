using ExercicioProdutosHeranca.Entities;
using System;

namespace ProdutosHerancaPolimorfismo
{
    internal class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdProducts = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtdProducts; i++) {
                Console.WriteLine($"\nProduct #{i + 1} data:");
                Console.Write("Comoon, used or imported (c/u/i): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch(ch) {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Custom fee: ");
                        double customFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;
                }
            }

            Console.WriteLine("\n\nPRICE TAGS:");
            products.ForEach(p => Console.WriteLine(p.priceTag()));
        }
    }
}