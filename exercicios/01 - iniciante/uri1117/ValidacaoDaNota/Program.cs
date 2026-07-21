using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double Nota, Media, Soma, Cont;

        Soma = 0;
        Cont = 0;
        while (Cont < 2)
        {
            Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (Nota < 0.0 || Nota > 10.0)
            {
                Console.WriteLine("nota invalida");
            }
            else {
                Soma += Nota;
                Cont++;
            }
        }
        Media = Soma / Cont;
        Console.WriteLine($"media = {Media.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.ReadLine();
    }
}