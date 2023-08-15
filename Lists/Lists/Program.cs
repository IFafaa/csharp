using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Insert(1, "Fabricio");
            list.Add("Pedro");
            list.Add("Beatriz");


            list.ForEach((x) => {
                Console.WriteLine(x);
            });

            Console.WriteLine("tamanho da lista:" , list.Count);

            List<string> listFiltered = list.FindAll((x) => x.Contains('a'));
            Console.WriteLine("lista filtrada com nomes que tem A:");
            listFiltered.ForEach((x) => { Console.WriteLine(x); });


        }
    }
}