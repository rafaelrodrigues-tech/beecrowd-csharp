using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (int i = 1; i <= 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont + " valores pares");
        }
    }
}