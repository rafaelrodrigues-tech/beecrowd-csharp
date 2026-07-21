using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) pares.Add(x);

            else impares.Add(x);
        }
        foreach (int p in pares.Order())
        {
            Console.WriteLine(p);
        }
        foreach (int i in impares.OrderDescending())
        {
            Console.WriteLine(i);
        }
    }
}