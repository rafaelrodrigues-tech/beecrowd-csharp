using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            double area = ((a + b) * c) / 2.0;
            double perimetro = a + b + c;

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }

            else
            {
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}