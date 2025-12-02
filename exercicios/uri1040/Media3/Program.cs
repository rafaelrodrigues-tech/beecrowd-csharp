using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        float N1, N2, N3, N4, media;
        string[] Notas = Console.ReadLine().Split(' ');
        N1 = float.Parse(Notas[0]);
        N2 = float.Parse(Notas[1]);
        N3 = float.Parse(Notas[2]);
        N4 = float.Parse(Notas[3]);

        media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / (2 + 3 + 4 + 1);

        Console.WriteLine(media);
        Console.ReadKey();
    }

}