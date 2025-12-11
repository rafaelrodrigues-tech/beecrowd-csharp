using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double a, b, c;
        string[] vet = Console.ReadLine().Split(' ');
        a = double.Parse(vet[0],CultureInfo.InvariantCulture);
        b = double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        double[] lados = {a, b, c};
        Array.Sort(lados);
        Array.Reverse(lados);

        a = lados[0];
        b = lados[1];
        c = lados[2];

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
            Console.ReadKey();
        }
        if (a * a == b * b + c * c)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        if (a * a > (b * b + c * c))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        if (a * a < b * b + c * c)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        if ((a == b && a != c) || ( a == c && a != b) || (b == c && b != a))
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
        Console.ReadKey();
    }
}