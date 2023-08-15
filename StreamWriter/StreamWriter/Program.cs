using System;
using System.IO;

namespace StreamWriterCourse
{
    internal class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";


            try {
                 string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException ex) {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}