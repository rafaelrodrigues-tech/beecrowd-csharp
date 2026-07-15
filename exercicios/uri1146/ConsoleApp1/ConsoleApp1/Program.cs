using System;
class URI
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        while (x > 0)
        {
            int i = 1;
            while (i <= x)
            { 
                Console.Write(i+" ");
                i++;
            }
            Console.WriteLine();
            x = int.Parse(Console.ReadLine());
        }
    }
}