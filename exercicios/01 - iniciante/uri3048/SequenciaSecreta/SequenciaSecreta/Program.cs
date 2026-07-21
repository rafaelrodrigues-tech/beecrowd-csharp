using System;
using System.Collections.Generic;

namespace SequenciaSecreta
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> v = new List<int>(n);

            for (int i = 1; i <= n; i++)
            {
                v.Add(int.Parse(Console.ReadLine()));

            }
            int cont = 1;

            for (int i = 1; i<= n-1; i++)
            {
                if (v[i] != v[i-1])
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        }
    }
}