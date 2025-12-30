using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int N;
        double notaA,notaB,notaC, mediaPonderada;
        N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {

            string[] media = Console.ReadLine().Split(' ');
            notaA = double.Parse(media[0],CultureInfo.InvariantCulture);
            notaB = double.Parse(media[1],CultureInfo.InvariantCulture);
            notaC = double.Parse(media[2],CultureInfo.InvariantCulture);

            mediaPonderada = ((notaA * 2) + (notaB * 3) + (notaC * 5)) / (2 + 3 + 5);
            Console.WriteLine(mediaPonderada.ToString("F1"),CultureInfo.InvariantCulture);

        }Console.ReadLine();

    }

}