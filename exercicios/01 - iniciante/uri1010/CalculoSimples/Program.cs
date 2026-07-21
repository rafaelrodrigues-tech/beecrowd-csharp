using System;
using System.Globalization;

namespace uri1010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int NumPecas = int.Parse(vet[1]);
            double ValorUm = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vetDois = Console.ReadLine().Split(' ');
            int codigoDois = int.Parse(vetDois[0]);
            int NumPecas2 = int.Parse(vetDois[1]);
            double ValorDois = double.Parse(vetDois[2], CultureInfo.InvariantCulture);

            double Total = (NumPecas * ValorUm) + (NumPecas2 * ValorDois);

            Console.WriteLine("VALOR A PAGAR: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }//split
}