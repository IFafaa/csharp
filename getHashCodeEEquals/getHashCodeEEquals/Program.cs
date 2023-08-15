using getHashCodeEEquals.Entities;
using System;

namespace getHashCodeEEquals {
    internal class Program {
        static void Main(string[] args) {
            string a = "maria";
            string b = "joao";

            Console.WriteLine(a.Equals(b)); //false
            Console.WriteLine(a.GetHashCode()); //random int ex: 93478334343
            Console.WriteLine(b.GetHashCode()); //random int ex: 38407334343

            Client c = new Client() {  Name = a , Email = "teste@gmail.com"};
            Client d = new Client() { Name = a, Email = "teste@gmail.com" };

            Console.WriteLine(c.Equals(d));

            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

        }
    }
}