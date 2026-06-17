using System;

class URI
{

    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0)
        {
            x++;
        }
        for (int i = 0; i < 6; i++)
        {
            if (x % 2 ==1)
            {
                Console.WriteLine(x);
            }
            x+=2;
        }

    }

}