using System;
class URI
{
    static void Main(string[] args)
    {
        string[] cartas = Console.ReadLine().Split(' ');
        int a = int.Parse(cartas[0]);
        int b = int.Parse(cartas[1]);

        if (a == b) Console.WriteLine(a);

        else if (a > b) Console.WriteLine(a);

        else Console.WriteLine(b);
    }
}