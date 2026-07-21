using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int cont = 0;

            string[] linha = Console.ReadLine().Split(' ');
            int a = int.Parse(linha[0]);
            int b = int.Parse(linha[1]);
            int c = int.Parse(linha[2]);
            int d = int.Parse(linha[3]);

            foreach (string num in linha)
            {
                if (num == n)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        }
    }
}