using System;

class URI
{

    static void Main(string[] args)
    {
        int opcao,alcool, gas, diesel;
        opcao = int.Parse(Console.ReadLine());

        alcool = gas = diesel = 0;

        while (opcao != 4)
        {
            switch (opcao)
            {
                case 1:
                    {
                        alcool += 1;
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        gas += 1;
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
                case 3:
                    {
                        diesel += 1;
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gas}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}