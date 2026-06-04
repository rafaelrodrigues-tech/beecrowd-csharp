using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;
            string[] MN = Console.ReadLine().Split(' ');
            N = int.Parse(MN[0]);
            M = int.Parse(MN[1]);
            mat = new int[N, M];
            int sabre = 42;
            bool encontrou = false;
            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            int posI = 0;
            int posJ = 0;
            for (int i = 1; i < N - 1 && !encontrou; i++)
            {
                for (int j = 1; j < M - 1 && !encontrou; j++)
                {
                    if (mat[i, j] == sabre)
                    {
                        if ((mat[i - 1, j - 1] == 7)
                                && (mat[i - 1, j] == 7)
                                && (mat[i - 1, j + 1] == 7)
                                && (mat[i, j - 1] == 7)
                                && (mat[i, j + 1] == 7)
                                && (mat[i + 1, j - 1] == 7)
                                && (mat[i + 1, j] == 7)
                                && (mat[i + 1, j + 1] == 7))
                        {

                            posI = i + 1;
                            posJ = j + 1;
                            encontrou = true;
                        }
                    }
                }
            }
            if (encontrou == true)
            {
                Console.WriteLine(posI + " " + posJ);
            }
            else
            {
                Console.WriteLine("0 0");
            }
        }
    }
}
