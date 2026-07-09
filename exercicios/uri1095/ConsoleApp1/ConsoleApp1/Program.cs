using System;
class URI
{
    static void Main(string[] args)
    {/*
        for (int i = 1; i <= 60; i += 3)
        {
            Console.WriteLine($"I={i}");

            for (int j = 60; j >= 0; j -= 5)
            {
                Console.WriteLine($"J={j}");
            }

        }
        */
        int i = 1;
        int j = 60;
        while (i <= 60 && j >= 0)
        {
            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
            
        }
    }
}
