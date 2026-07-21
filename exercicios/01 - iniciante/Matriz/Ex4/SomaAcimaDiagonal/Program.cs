using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] l = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(l[j]);
                }
            }
            int soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (j > i)
                    {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}