using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            for (int i = 1; i <= 6; i++)
            {
                double values = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);//vai usar o ponto (padrão internacional)
                if (values >= 0.0)
                {
                    positive++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(positive + " valores positivos");
        }
    }
}