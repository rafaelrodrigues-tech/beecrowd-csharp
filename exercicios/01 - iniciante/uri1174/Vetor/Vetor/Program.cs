using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
        double[] vetor = new double[5];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }
        int cont = 0; 
        for (int j = 0; j < vetor.Length; j++)
        {
            if (vetor[j] <= 10.0)
            {
                Console.WriteLine($"A[{cont}] = {vetor[j].ToString("F1", CultureInfo.InvariantCulture)}");
                cont++;
            }
        }
    }
}