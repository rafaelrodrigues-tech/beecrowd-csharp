using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double div = (double)x / (double)y;
                Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}