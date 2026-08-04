using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());//21
        int y = int.Parse(Console.ReadLine());//21
        int valores = 1;
        while (x >= y)
        {
            y = int.Parse(Console.ReadLine()); //15
            if (y > x)
            {
                while (valores <= y)
                { 
                    
                }
            }
        }
        Console.WriteLine(valores);
    }
}