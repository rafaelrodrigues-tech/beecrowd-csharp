using System;
class URI
{
    static void Main(string[] args)
    {
        int pos = 0;
        string[] copo = Console.ReadLine().Split(' ');
        for (int i = 0; i < copo.Length; i++)
        {
            int x = int.Parse(copo[i]);
            if (x == 1)
            {
                pos = i;
            }
        }
            Console.WriteLine(pos+1);
    }
}