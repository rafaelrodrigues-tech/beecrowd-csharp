using System;

class URI
{

    static void Main(string[] args)
    {
        int x, y;
        
        string[] vetor = Console.ReadLine().Split(' ');
        x = int.Parse(vetor[0]);
        y = int.Parse(vetor[1]);
        while (x != y)
        {
            if (x > y)
            {
                Console.WriteLine("Decrescente");

            }
            else
            {
                Console.WriteLine("Crescente");
            }
            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
        }
        Console.ReadKey();
    }
}