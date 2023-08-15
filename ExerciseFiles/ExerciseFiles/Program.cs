using ExerciseFiles.Entities;
using System;
using System.Globalization;

namespace ExerciseFiles
{
    internal class Program {
        static void Main(string[] args) {
            string directoryPath = @"c:\study\csharp\temp";
            string filePath = directoryPath + @"\itens.csv";
            string directoryNew = directoryPath + @"\out";
            string refactorFilePath = directoryNew + @"\summary.csv";

            try {
                using(StreamReader sr = File.OpenText(filePath)) {
                    List<Product> products = new List<Product>();
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0].Trim();
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(line[2]);
                        products.Add(new Product(name, price, quantity));
                    }

                    Directory.CreateDirectory(directoryNew);
                    using(StreamWriter sw = File.CreateText(refactorFilePath)) {
                        foreach(Product product in products) {
                            sw.WriteLine($"{product.name},{product.totalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }
            catch (IOException ex){
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}