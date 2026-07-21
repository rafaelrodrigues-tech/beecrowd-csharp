using System;
class URI
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int menor = x;
        int maior = y;
        if (y < x)
        {
            menor = y;
            maior = x;
        }
        int soma = 0;
        for (int i = menor; i <= maior; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}