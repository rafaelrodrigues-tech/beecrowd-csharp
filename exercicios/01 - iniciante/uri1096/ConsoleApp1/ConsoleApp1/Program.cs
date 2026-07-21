using System;

class URI
{

    static void Main(string[] args)
    {
        int i = 1;
        int j = 7;
        while (i <= 9)
        {
            if (j >= 5)
            {
                Console.WriteLine($"I={i} J={j}");
                j -= 1;
            }
            else
            {
                j += 3;
                i += 2;
            }
        }
    }

}