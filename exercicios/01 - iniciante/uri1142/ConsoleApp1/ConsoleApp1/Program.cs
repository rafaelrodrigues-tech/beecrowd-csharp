using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int i = 1;
        int linha = 1;
        while (linha <= n)
        {
            if (!(i % 4 == 0))
            {
                Console.Write(i + " ");
                i++;
            }
            else
            {
                linha++;
                Console.Write("PUM\n");
                i++;
            }
        }
    }
}