using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int N;
        int Coelhos = 0;
        int Ratos = 0;
        int Sapos = 0;
        N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            string[] cobaias = Console.ReadLine().Split(' ');
            int quantia = int.Parse(cobaias[0]);
            char tipo = char.Parse(cobaias[1]);
            if (tipo == 'C')
            {
                Coelhos += quantia;
            }
            else if (tipo == 'R')
            {
                Ratos += quantia;
            }
            else if (tipo == 'S')
            {
                Sapos += quantia;
            }
        }
        int total = Coelhos + Ratos + Sapos;
        double percCoelhos = (double)Coelhos / total * 100.00;
        double percRatos = (double)Ratos / total * 100.00;
        double percSapos = (double)Sapos / total * 100.00;
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + Coelhos);
        Console.WriteLine("Total de ratos: " + Ratos);
        Console.WriteLine("Total de sapos: " + Sapos);
        Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2", CultureInfo.InvariantCulture) + "%");
        Console.ReadLine();
    }
}