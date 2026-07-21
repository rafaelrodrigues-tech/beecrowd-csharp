using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            double avg = 0.0;
            double sum = 0.0;
            for (int i = 1; i <= 6; i++)
            {
                double values = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (values >= 0.0)
                {
                    positive++;
                    sum += values;
                }
            }
            avg = sum / positive;
            Console.WriteLine(positive + " valores positivos");
            Console.WriteLine(avg.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}