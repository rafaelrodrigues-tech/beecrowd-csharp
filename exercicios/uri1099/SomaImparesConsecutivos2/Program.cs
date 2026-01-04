using System;

class URI
{
    static void Main(string[] args)
    {
        int N, X, Y;
        int menor;
        int maior;
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            X = int.Parse(valores[0]);
            Y = int.Parse(valores[1]);
            menor = Math.Min(X, Y);
            maior = Math.Max(X, Y);
            int soma = 0;
            for (int j = menor + 1; j < maior; j++)
              {
                  if (j % 2 != 0)
                  {
                      soma += j;
                  }
              }
            Console.WriteLine(soma);
        }
    }
}