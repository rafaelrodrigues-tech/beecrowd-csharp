using System;
class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int soma = 0;
            int x = int.Parse(Console.ReadLine());
            for (int j = 1; j < x; j++)
            {
                if (x % j == 0)
                {
                    soma += j;
                }
            }
            if (soma == x)
            {
                Console.WriteLine($"{x} eh perfeito");
            }
            else {
                Console.WriteLine($"{x} nao eh perfeito");
            }
        }
    }
}