using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            if (a % 2 == 0)
            {
                a += 1;
            }
            int soma = 0;
            for (int j = 1; j <= b; j++)
            {
                soma += a;
                a += 2;
            }
            Console.WriteLine(soma);
        }
    }

}