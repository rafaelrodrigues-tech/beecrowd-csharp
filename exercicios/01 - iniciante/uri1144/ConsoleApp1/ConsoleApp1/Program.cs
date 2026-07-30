using System;

class URI
{

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int a = 1;
        double b = 1;
        double c = 1;
        for (int i = 1; i <= (n * 2); i++)
        {
            Console.WriteLine($"{a} {b} {c}");
            if (i % 2 == 0)
            {
                a++;
                b = Math.Pow(a, 2);
                c = Math.Pow(a, 3);
            }
            else
            {
                b++;
                c++;
            }
        }
    }
}