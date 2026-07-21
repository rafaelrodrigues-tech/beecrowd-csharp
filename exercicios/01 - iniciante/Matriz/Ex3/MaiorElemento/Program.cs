using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;
            N = int.Parse(Console.ReadLine());
            A = new int[N,N];

            for (int i = 0; i < N; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(linha[j]);
                }
            }
            int[] mat = new int[N];
            for (int i = 0; i < N; i++) {
                int maior = 0;
                for (int j = 0; j < N; j++) {
                    if (A[i, j] > maior) {
                        maior = A[i, j];
                    }
                    mat[i] = maior;
                }
            }
            for (int i = 0; i < N; i++) {
                Console.WriteLine(mat[i]);
            }
            Console.ReadLine();
        }
    }
}