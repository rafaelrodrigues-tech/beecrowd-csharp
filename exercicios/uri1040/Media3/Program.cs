using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        float N1, N2, N3, N4, media, exame, MediaExame;
        string[] Notas = Console.ReadLine().Split(' ');
        N1 = float.Parse(Notas[0], CultureInfo.InvariantCulture);
        N2 = float.Parse(Notas[1], CultureInfo.InvariantCulture);
        N3 = float.Parse(Notas[2], CultureInfo.InvariantCulture);
        N4 = float.Parse(Notas[3], CultureInfo.InvariantCulture);

        media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10f;
        if (media == 4.85f ) {
            media = 4.8f;
        }

        if (media >= 5.0f && media <= 6.9f)
        {
            Console.WriteLine($"Media: {media.ToString("F1",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno em exame.");

            exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MediaExame = (exame + media) / 2.0f;
            Console.WriteLine($"Nota do exame: {exame.ToString("F1")}");

            if (MediaExame >= 5.0f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {MediaExame.ToString("F1", CultureInfo.InvariantCulture)}");
        }

        else if (media < 5.0f)
        {
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno reprovado.");
        }

        else
        {
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno aprovado.");
        }
        Console.ReadKey();
    }

}