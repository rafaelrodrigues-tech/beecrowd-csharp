using System;

class URI
{
    static void Main(string[] args)
    {
        string[] v = Console.ReadLine().Split(' ');

        int hi = int.Parse(v[0]);
        int mi = int.Parse(v[1]);
        int hf = int.Parse(v[2]);
        int mf = int.Parse(v[3]);

        int inicio = hi * 60 + mi;
        int fim = hf * 60 + mf;

        if (fim <= inicio)
        {
            fim += 24 * 60;
        }

        int duracao = fim - inicio;

        int horas = duracao / 60;
        int minutos = duracao % 60;

        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        Console.ReadKey();
    }
}
