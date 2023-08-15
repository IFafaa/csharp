using calculadora;
using System;

namespace Calculadora 
{
    internal class Program {
        static double Pi = 3.14;
        static CalculadoraRaio calc = new CalculadoraRaio();

        static void Main(string[] args) {
            //LerDados();
            //IniciarCalcRaio();
            LerCalcUtilitaria();
        }

        static void LerCalcUtilitaria() {
            Console.WriteLine("Digite o raio:");
            double raio = double.Parse(Console.ReadLine());

            double circ = CalculadoraUtilitaria.Circuferencia(raio);
            double vol = CalculadoraUtilitaria.Volume(raio);

            Console.WriteLine($"Circuferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {CalculadoraUtilitaria.Pi}");
        }
        static void IniciarCalcRaio() {
            Console.WriteLine("Digite o raio:");
            calc.raio = double.Parse(Console.ReadLine());

            double circ = calc.Circuferencia();
            double vol = calc.Volume();

            Console.WriteLine($"Circuferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {Pi}");
        }

        static void LerDados() {
            Console.WriteLine("Digite o raio:");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circuferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine($"Circuferência: {circ.ToString("F2")}");
            Console.WriteLine($"Volume: {vol.ToString("F2")}");
            Console.WriteLine($"Valor de PI: {Pi}");
        }

        static double Circuferencia(double r) {
            return 2.0 * r * Pi;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}