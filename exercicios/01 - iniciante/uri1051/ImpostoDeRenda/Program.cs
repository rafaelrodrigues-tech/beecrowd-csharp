using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double renda;
        double imposto = 0.0;
        renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        if (renda <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            if (renda > 2000.00 && renda <= 3000.00)
            {
                imposto = (renda - 2000.00) * 0.08;
            }
            else if (renda > 3000.00 && renda <= 4500.00)
            {
                imposto = (1000.00 * 0.08) + ((renda - 3000.00) * 0.18);
            }
            else
            {
                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((renda - 4500.00) * 0.28);
            }
            Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }   Console.ReadKey();
    }
}