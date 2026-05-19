using System;

namespace consoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int subtracao = n - m;
            Console.WriteLine(subtracao);
        }
    }
}