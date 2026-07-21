using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int opcao = 1;

        while (opcao == 1)
        {
            double soma = 0;
            int cont = 0;

            while (cont < 2)
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0.0 || nota > 10.00)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma += nota;
                    cont++;
                }
            }
                double media = soma / 2;
                Console.WriteLine($"media = {media.ToString("F2",CultureInfo.InvariantCulture)}");

                do
                {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
                }
                while (opcao != 1 && opcao != 2);
        }
    }
}