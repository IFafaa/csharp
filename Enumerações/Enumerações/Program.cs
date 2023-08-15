using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o ID do produto escolhido: ");
            int idProduct = int.Parse(Console.ReadLine());
            Order order = new Order(idProduct);
        }
    }
}