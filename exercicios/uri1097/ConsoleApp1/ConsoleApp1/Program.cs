using System;
class URI
{
    static void Main(string[] args)
    {
        int i = 1;
        int j = 7;
        while (i < 11)
        {
            if (!(j - i == 3))
            {
                Console.WriteLine($"I={i} J={j}");
                j -= 1;
            }
            else{
                i += 2;
                j += 5;
            }
        }
    }
}