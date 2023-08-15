using System;
using System.Globalization;

namespace MyApp
{
    internal class Program {
        static void Main(string[] args) {
            //TIPOS DE VARIAVEIS

            //char caractere = 'F';
            //char caractereUnicode = '\u0041';
            //bool boleano = false;
            //int numero = 234234523;
            //double numeroDecimal = 4.3994;
            //string texto = "texto texto texto texto";
            //object obj = "teste";
            //object obj2 = 42;

            //Console.WriteLine(caractere);
            //Console.WriteLine(caractereUnicode);
            //Console.WriteLine(boleano);
            //Console.WriteLine(numero);
            //Console.WriteLine(numeroDecimal.ToString("F2")); //formatar quantidade de casas decimais
            //Console.WriteLine(numeroDecimal.ToString("F3", CultureInfo.InvariantCulture)); //formatar separador decimal
            //Console.WriteLine(texto);
            //Console.WriteLine(obj);
            //Console.WriteLine(obj2);


            //INTERPOLAÇÃO DO WRITELINE
            byte idade = 18;
            int saldo = 13000;
            string nome = "Fabrício";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2"));

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2")} reais");

            //CONVERSAO DE TIPOS

            int numero = int.Parse(Console.ReadLine());
            int letter = char.Parse(Console.ReadLine());
            string text = 23.ToString();

        }

        //FUNÇÕES
        static int dobro(int numero) {
            return numero * 2;
        }
    }
}