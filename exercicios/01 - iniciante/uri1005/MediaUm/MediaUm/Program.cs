using System;
using System.Globalization;

namespace MediaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, PesoA, PesoB, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            PesoA = 3.5;
            PesoB = 7.5;
            MEDIA = (A * PesoA + B * PesoB) / (PesoA + PesoB);


            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}