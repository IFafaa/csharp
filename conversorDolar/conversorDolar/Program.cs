using conversorDolar;
using System;

namespace conversorMoeda
{
    internal class Program {
        static void Main(string[] args) {
            lerMoeda();
        }

        static void lerMoeda() {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantidade = double.Parse(Console.ReadLine());

            double valor = Conversor.conversorRealDolar(quantidade, cotacao);
            Console.WriteLine($"Valor a ser pago em reais = {valor + Conversor.valorDaTaxa(valor)}");
        }
    }
}