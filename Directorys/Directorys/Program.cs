using System;

namespace MyApp 
{
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\minhaPasta";

            try {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folder in folders) {
                    Console.WriteLine(folder);
                }


                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (var file in files) {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + "\\newFolder");

            }
            catch (IOException ex) {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}