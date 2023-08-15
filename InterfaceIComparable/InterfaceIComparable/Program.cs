using InterfaceIComparable.Model.Entities;
using System;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {
            try {
                string path = @"c:/temp/funcionarios.txt";
                List<Worker> Workers = new List<Worker>();

                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        Workers.Add(new Worker(sr.ReadLine()));
                    }
                }
                Workers.Sort();
                Workers.ForEach(worker => { Console.WriteLine(worker.ToString()); });


            }catch (IOException ex) {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}