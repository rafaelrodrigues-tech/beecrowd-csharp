using System;

class uri1046
{

    static void Main(string[] args)
    {
        int HoraInicial, HoraFinal, Res;
        string[] vet = Console.ReadLine().Split(' ');
        HoraInicial = int.Parse(vet[0]);
        HoraFinal = int.Parse(vet[1]);

        if (HoraInicial < HoraFinal)
        {
            Res = HoraFinal - HoraInicial;
            Console.WriteLine($"O JOGO DUROU {Res} HORA(S)");
        }
        else
        {
            Res = (24 + HoraFinal) - HoraInicial;
            Console.WriteLine($"O JOGO DUROU {Res} HORA(S)");
        }
    }
}