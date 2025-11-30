using System;
using System.Globalization;

namespace uri1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, PesoA, PesoB, PesoC, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            PesoA = 2.0;
            PesoB = 3.0;
            PesoC = 5.0;
            MEDIA = ((A * PesoA) + (B * PesoB) + (C * PesoC)) / (PesoA + PesoB + PesoC);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}