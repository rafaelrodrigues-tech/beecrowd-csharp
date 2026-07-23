using System;
class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        Console.Write(a + " "+ b);
        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.Write(" " + c);
            a = b;
            b = c;
        }
    }
}