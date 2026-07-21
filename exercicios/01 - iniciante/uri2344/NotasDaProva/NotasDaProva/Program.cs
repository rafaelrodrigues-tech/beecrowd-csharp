using System;

namespace MyApp
{
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("E");

            }
            else if (n < 36)
            {
                Console.WriteLine("D");
            }
            else if (n < 61)
            {
                Console.WriteLine("C");
            }
            else if (n < 86)
            {
                Console.WriteLine("B");
            }
            else {
                Console.WriteLine("A");
            }
        }
    }
}