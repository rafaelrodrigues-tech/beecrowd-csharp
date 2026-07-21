using System;

class URI
{

    static void Main(string[] args)
    {
        int N, M;
        int menor;
        int maior;
        while (true)
        {
            string[] valores = Console.ReadLine().Split();
            N = int.Parse(valores[0]);
            M = int.Parse(valores[1]);
            if (N <= 0 || M <= 0)
            {
                break;
            }
            menor = Math.Min(N, M);
            maior = Math.Max(N, M);
            int soma = 0;
            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i+" ");
                soma += i;
            }
            Console.WriteLine("Sum="+soma);
        }
        Console.ReadLine();
    }
}