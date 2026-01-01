using System;

class URI
{

    static void Main(string[] args)
    {
        int num;
        int maior = int.Parse(Console.ReadLine());
        for (int i = 0; i <= 100; i++)
        {
            num = int.Parse(Console.ReadLine());
            
            if (num > maior)
            {
                maior = num;
            }

        }
        Console.WriteLine(maior);
        Console.ReadLine();

    }

}