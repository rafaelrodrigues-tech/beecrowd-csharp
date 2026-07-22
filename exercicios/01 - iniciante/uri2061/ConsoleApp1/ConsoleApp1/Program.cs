using System;

class URI
{

    static void Main(string[] args)
    {
        string[] abas = Console.ReadLine().Split(' ');
        int n = int.Parse(abas[0]);
        int m = int.Parse(abas[1]);
        for (int i = 1; i <= m; i++)
        { 
            string resultado = Console.ReadLine();
            if (resultado == "fechou")
            {
                n = (n - 1) + 2;
            }
            else
            {
                n -= 1;
            }
        }
        Console.WriteLine(n);

    }

}