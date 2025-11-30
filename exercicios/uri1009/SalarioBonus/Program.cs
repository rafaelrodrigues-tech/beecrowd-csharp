using System;
using System.Globalization;

namespace uri1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SalarioFixo, TotalVendas, Total;
            string NomeVendedor = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine());
            TotalVendas = double.Parse(Console.ReadLine());
            Total = SalarioFixo + (TotalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}