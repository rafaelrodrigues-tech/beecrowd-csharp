using System;

class URI
{

    static void Main(string[] args)
    {
        string a, b, c;
        a = Console.ReadLine();
        b = Console.ReadLine();
        c = Console.ReadLine();
        switch (a)
        {
            case "vertebrado":
                if (b == "ave")
                {
                    if (c == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (c == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
                break;

            case "invertebrado":
                if (b == "inseto")
                {
                    if (c == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (c == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                    else
                    {
                        Console.WriteLine("sanguessuga");
                    }
                }
                break;
        }Console.ReadKey();
    }
}