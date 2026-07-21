using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int top = 0;

            if (n == 1)
            {
                top = 1;
            }
            else if (n <= 3)
            {
                top = 3;
            }
            else if (n <= 5)
            {
                top = 5;
            }
            else if (n <= 10)
            {
                top = 10;
            }
            else if (n <= 25)
            {
                top = 25;
            }
            else if (n <= 50)
            {
                top = 50;
            }
            else {
                top = 100;
            }
            Console.WriteLine("Top " + top);

        }
    }
}