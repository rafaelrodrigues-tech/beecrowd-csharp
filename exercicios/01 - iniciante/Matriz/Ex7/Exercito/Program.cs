using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] matriz;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i,j]+ " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}