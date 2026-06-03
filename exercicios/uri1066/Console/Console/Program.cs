using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    par++;
                    if (x > 0)
                    {
                        pos++;
                    }
                    if (x < 0)
                    {
                        neg++;
                    }
                }
                else
                {
                    impar++;
                    if (x > 0)
                    {
                        pos++;
                    }
                    if (x < 0)
                    {
                        neg++;
                    }
                }
            }
            Console.WriteLine($"{par} valor (es) par (es)");
            Console.WriteLine($"{impar} valor (es) impar (es)");
            Console.WriteLine($"{pos} valor (es) positivo (s)");
            Console.WriteLine($"{neg} valor (es) negativo (s)");
        }
    }
}