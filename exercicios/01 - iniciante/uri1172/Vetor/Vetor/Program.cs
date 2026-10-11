using System;
class URI
{
    static void Main(string[] args)
    {
        int[] vet = new int[10];
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
            if (vet[i] <= 0)
            {
                vet[i] = 1;
            }
        }
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"X[{i}] = {vet[i]}");
        }
    }
}