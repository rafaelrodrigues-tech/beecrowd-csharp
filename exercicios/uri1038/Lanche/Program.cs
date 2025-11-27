using System;
using System.Globalization;

class Lanche
{

    static void Main(string[] args)
    {
        int codigo, quantidade;
        double Lanche;
        string[] vet = Console.ReadLine().Split(' ');
        codigo = int.Parse(vet[0]);
        quantidade = int.Parse(vet[1]);

        switch (codigo){
            case 1:
                Lanche = 4.00 * quantidade;
                break;
            case 2:
                Lanche = 4.50 * quantidade;
                break;
            case 3:
                Lanche = 5.00 * quantidade;
                break;
            case 4:
                Lanche = 2.00 * quantidade;
                break;
            case 5:
                Lanche = 1.50 * quantidade;
                break;
            default:
                Lanche = 0.0;
                break;
        }
        Console.WriteLine($"Total: R$ {Lanche.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.ReadKey();
    } 
}