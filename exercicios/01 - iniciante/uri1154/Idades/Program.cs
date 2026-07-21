using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int cont = 0;
        int soma = 0;
        double media;

        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            cont++;
            soma += idade;
            idade = int.Parse(Console.ReadLine());
        }

        media = (double)soma / cont;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}