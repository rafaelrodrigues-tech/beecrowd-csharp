using System;
using System.Globalization;
namespace TourOfCsharp;

class Program
{
    static void Main()
    {
         
        int N;
        double[,] mat;

        N = int.Parse(Console.ReadLine());
        mat = new double[N,N];
       //A
        for (int i = 0; i < N; i++) {
            string[] l = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++) {
                mat[i, j] = double.Parse(l[j],CultureInfo.InvariantCulture);
            }
        }
        //B
        double soma = 0.0;
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (mat[i, j] > 0.0)
                {
                    soma = soma + mat[i, j]; 
                }
            }
        }
        Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));

        
        int indice = int.Parse(Console.ReadLine());
        for (int j = 0; j < N; j++)
          {
            Console.Write(mat[indice,j]+" ");

          }
        Console.WriteLine();

        int coluna = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++) {
            Console.Write(mat[i,coluna]+ " ");
        }
        Console.WriteLine();

        for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i]+" ");
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (mat[i, j] < 0.0)
                {
                    mat[i,j] = mat[i,j] * mat[i, j];
                }
            }
        }
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                Console.Write(mat[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}