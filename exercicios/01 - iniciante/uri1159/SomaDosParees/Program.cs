using System;

class URI
{

    static void Main(string[] args)
    {

        int x, soma, cont;
        x = int.Parse(Console.ReadLine());

        while (x != 0)
        {
            if (x % 2 == 1)
            {
                x++;
            }

            soma = 0;
            cont = 0;

            while (cont < 5)
            {
                soma += x;
                x += 2;
                cont++;
            }
            Console.WriteLine(soma);
            x = int.Parse(Console.ReadLine());
        }
    }
}
