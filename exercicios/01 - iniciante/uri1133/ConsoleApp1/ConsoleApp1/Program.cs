using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int maior = y;
        int menor = x;
        if (y < x)
        { 
            menor = y;
            maior = x;
        }
        for (int i = menor + 1; i < maior; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            { 
                Console.WriteLine(i);
            }
        }

    }

}