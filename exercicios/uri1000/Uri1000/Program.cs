using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Uri1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaUM, notaDois, notaFinal;
            notaUM = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            notaDois = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            notaFinal = notaUM + notaDois;

            if (notaFinal > 60.00)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F1",CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
            }
                Console.ReadKey();
        }
    }
}