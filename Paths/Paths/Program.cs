using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\minhaPasta\newFolder\text1.txt";

            Console.WriteLine("GetDirectoryName:  " + Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator:  " + Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar:  " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetFileName:  " + Path.GetFileName(path));
            Console.WriteLine("GetExtension:  " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension:  " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath:  " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath:  " + Path.GetTempPath());






        }
    }
}