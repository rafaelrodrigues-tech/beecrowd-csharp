using System;

class URI
{

    static void Main(string[] args)
    {
        int N, X;
        int ContIn = 0;
        int ContOut = 0;
        N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++) 
        {
            X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                ContIn++;
            }
            else
            {
                ContOut++;   
            }
        }
        Console.WriteLine(ContIn +" in");
        Console.WriteLine(ContOut +" out");
        Console.ReadLine();
    }
}