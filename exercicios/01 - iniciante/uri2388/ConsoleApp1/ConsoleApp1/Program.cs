using System;
class URI
{
    static void Main(string[] args)
    {
        int distancia = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int tempo = int.Parse(numbers[0]);
            int velocidade = int.Parse(numbers[1]);
            distancia += tempo * velocidade ;
        }
        Console.WriteLine(distancia);
    }
}