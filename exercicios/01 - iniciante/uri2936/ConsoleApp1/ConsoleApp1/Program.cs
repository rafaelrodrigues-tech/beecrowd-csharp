using System;
using System.Collections.Generic;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 300, 1500,600,1000,150};
            int chica = 225;
            int consumo = 0;
            for (int i = 0; i <=4; i++)
            {
                int qtdd = int.Parse(Console.ReadLine());
                consumo = qtdd * numeros[i];
                chica += consumo;
            }
            Console.Write(chica);
        }
    } 
}