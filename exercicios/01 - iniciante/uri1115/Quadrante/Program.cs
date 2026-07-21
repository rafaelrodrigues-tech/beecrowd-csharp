using System;

class URI
{

    static void Main(string[] args)
    {
        int x, y;
        string[] vetor = Console.ReadLine().Split(' ');
        x = int.Parse(vetor[0]);
        y = int.Parse(vetor[1]);

        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else
            {
                Console.WriteLine("quarto");
            }
            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
        }
        Console.ReadLine();
    }

}