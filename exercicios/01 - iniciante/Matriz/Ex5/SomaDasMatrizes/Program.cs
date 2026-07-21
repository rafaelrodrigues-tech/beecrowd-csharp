using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;
            int[,] B;
            int[,] C;

            string[] MN = Console.ReadLine().Split(' ');
            M = int.Parse(MN[0]);
            N = int.Parse(MN[1]);


            A = new int[M, N];
            B = new int[M, N];
            for (int i = 0; i < M; i++) {
                string[] l1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(l1[j]); 
                }
            }

            for (int i = 0; i < M; i++)
            {
                string[] l2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(l2[j]);
                }
            }

            C = new int[M, N];

            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {

                    soma = A[i, j] + B[i, j];
                    C[i, j] = soma;
                }
            }
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}