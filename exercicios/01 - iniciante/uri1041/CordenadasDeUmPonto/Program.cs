using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double x, y;
        string[] ponto = Console.ReadLine().Split(' ');
        x = double.Parse(ponto[0], CultureInfo.InvariantCulture);
        y = double.Parse(ponto[1], CultureInfo.InvariantCulture);

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }

}