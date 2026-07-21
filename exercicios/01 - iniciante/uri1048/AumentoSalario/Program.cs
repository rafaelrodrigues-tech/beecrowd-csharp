using System;
using System.Globalization;

class uri1048
{

    static void Main(string[] args)
    {
        double salario, NovoSalario, Reajuste, percente;
        salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        if (salario <= 400.00)
        {
            NovoSalario = salario + (salario * 0.15);
            Reajuste = salario * 0.15;
            percente = 15;
        }
        else if (salario <= 800.00)
        {
            NovoSalario = salario + (salario * 0.12);
            Reajuste = salario * 0.12;
            percente = 12;

        }
        else if (salario <= 1200.00)
        {
            NovoSalario = salario + (salario * 0.10);
            Reajuste = salario * 0.10;
            percente = 10;
        }
        else if (salario <= 2000.00)
        {
            NovoSalario = salario + (salario * 0.07);
            Reajuste = salario * 0.07;
            percente = 7;
        }
        else
        {
            NovoSalario = salario + (salario * 0.04);
            Reajuste = salario * 0.04;
            percente = 4;
        }

        Console.WriteLine($"Novo salario: {NovoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Reajuste ganho: {Reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Em percentual: {percente} %");
        Console.ReadKey();
    }
}