using System;

namespace FatorialSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine(n);
        }
    }
}