using System;
using System.Globalization;

namespace uri1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number, HorasTrabalhadas;
            double Salary, HorasSalario;

            Number = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine());
            HorasSalario = double.Parse(Console.ReadLine());


            Salary = HorasSalario * HorasTrabalhadas;

            Console.WriteLine("NUMBER = " + Number);
            Console.WriteLine("SALARY = U$ " + Salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}