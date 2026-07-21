using System;
using System.Collections.Generic;
class URI
{   
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int soma = 0;
        List<int> numb = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            string[] numbers = Console.ReadLine().Split(" ");
            int r1 = int.Parse(numbers[0]);
            int r2 = int.Parse(numbers[1]);
            numb.Add(soma = r1 + r2);
        }
        foreach (int x in numb) Console.WriteLine(x); 
    }
}