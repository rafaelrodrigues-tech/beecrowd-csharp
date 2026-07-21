using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M,N;
            int[,] A;

            string[] MN = Console.ReadLine().Split(' ');
            M = int.Parse(MN[0]);
            N = int.Parse(MN[1]);
            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        Console.WriteLine(A[i,j]);
                    }
                }            
            }
            Console.ReadLine();
        }
    }
}