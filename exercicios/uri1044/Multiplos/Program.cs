using System;

class uri1044
{

    static void Main(string[] args)
    {
        int a, b;
        string[] multiplos = Console.ReadLine().Split(' ');
        a = int.Parse(multiplos[0]);
        b = int.Parse(multiplos[1]);

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}