using System;
using System.Globalization;
class URI
{
    static void Main(string[] args)
    {
        double i = 0;
        while (i <= 2)
        {
            for (int k = 0; k < 3; k++)
            {
                double j = 1+i+k;
                double valorI = Math.Round(i, 1);
                if ((valorI == 0.0) ||(valorI == 1.0) ||(valorI == 2.0))
                {
                    Console.WriteLine($"I={valorI} J={j}");
                }
                else
                {                 
                    Console.WriteLine($"I={valorI.ToString("F1", CultureInfo.InvariantCulture)} J={j.ToString("F1", CultureInfo.InvariantCulture)}");      
                }
            }
            
            i += 0.2;
        }
    }
}