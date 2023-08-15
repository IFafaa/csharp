using System;
using System.Collections.Generic;

namespace Matrizes
{
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite qual deve ser a quantidade de linhas e de colunas da matriz:");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            
            for (int i = 0; i < n; i++) {
                Console.Write($"Digite a {i + 1}ª linha da matriz (separados por espaço) : ");
                string[] enterValues = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(enterValues[j]);
                }
            }

            int[] diagonaisPrincipais = new int[n];
            List<int> numerosNegativos = new List<int>();

            Console.WriteLine("\n \nMatriz:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write($"{matriz[i, j]} ");
                    if(j == i) {
                        diagonaisPrincipais[i] = matriz[i,j];
                    }
                    if (matriz[i,j] < 0) {
                        numerosNegativos.Add(matriz[i,j]);
                    }
                }
                Console.WriteLine("");
            }

            Console.Write("\nDiagonal principal:");
            foreach (int i in diagonaisPrincipais) {
                Console.Write($"{i} ");
            }

            Console.Write($"\nQuantidade de números negativos: {numerosNegativos.Count}");

        }
    }
}