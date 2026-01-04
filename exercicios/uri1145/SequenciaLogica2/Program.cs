using System;

class URI
{

    static void Main(string[] args)
    {
        int X, Y;

        string[] sequencia = Console.ReadLine().Split(' ');
        X = int.Parse(sequencia[0]);
        Y = int.Parse(sequencia[1]);
        for (int i = 1; i <= Y; i++) 
        {
            if (i % X == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadLine();
    }
}