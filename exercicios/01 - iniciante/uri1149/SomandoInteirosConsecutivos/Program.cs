using System;

class URI
{

    static void Main(string[] args)
    {
        int A, N;
        string[] valores = Console.ReadLine().Split(' ');

        A = int.Parse(valores[0]);
        N = int.Parse(valores[1]);

        while (N <= 0)
        {
            valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            N = int.Parse(valores[1]);
        }

        int soma = 0;
        for (int i = A; i <= A+N-1;i++)
        {
            soma += i;
        }
        Console.WriteLine(soma);
        Console.ReadLine();
    }
}