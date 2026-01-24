using System;
namespace TourOfCsharp;

class Program
{
    static void Main()
    {
        int N;
        int[,] A;

        N = int.Parse(Console.ReadLine());
        A = new int[N,N];

        for (int i = 0; i < N; i++){
            string[] l = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++){
                A[i, j] = int.Parse(l[j]);
            }
        }
        int[] vet = new int[N];
        for (int i = 0; i < N; i++){
            int soma = 0;
            for (int j = 0; j < N; j++) {
                soma = soma + A[i,j];
            }
            vet[i] = soma;
        }
        for (int i = 0; i < N; i++) {
                Console.WriteLine(vet[i]);
        } 
        Console.ReadLine();
    }
}