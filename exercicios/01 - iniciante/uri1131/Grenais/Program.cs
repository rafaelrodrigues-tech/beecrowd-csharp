using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

class URI
{

    static void Main(string[] args)
    {
        int inter, gremio;
        int empates = 0;
        int VitoriasInter = 0;
        int VitoriasGremio = 0;
        int total = 0;
        int resposta;
        do
        {
            string[] grenal = Console.ReadLine().Split(' ');
            inter = int.Parse(grenal[0]);
            gremio = int.Parse(grenal[1]);

            total++;

            if (inter > gremio)
            {
                VitoriasInter++;
            }
            else if (inter < gremio)
            {
                VitoriasGremio++;
            }
            else
            {
                empates++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            resposta = int.Parse(Console.ReadLine());
        }
        while (resposta == 1);
        {
            Console.WriteLine($"{total} grenais");
            Console.WriteLine($"Inter:{VitoriasInter}");
            Console.WriteLine($"Gremio:{VitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (VitoriasInter > VitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (VitoriasInter < VitoriasGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}