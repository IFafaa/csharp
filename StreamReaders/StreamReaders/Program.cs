using System;
using System.IO;
using System.Text;

namespace StreamReaders
{
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {

                //fs = new FileStream(path, FileMode.Open);

                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    Console.WriteLine(sr.ReadLine());
                }


                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (IOException ex) {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally {
                //if (fs != null) fs.Close();
                if(sr != null) sr.Close();
            }
        }
    }
}