using System;
using System.IO;

namespace UsingBlock
{
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex) {
                Console.WriteLine("Houve um erro: " + ex.Message);
            }
        
        }
    }
}