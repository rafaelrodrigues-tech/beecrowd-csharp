using System;

class URI
{

    static void Main(string[] args)
    {
        int senha;
        int senhaValida = 2002;
        senha = int.Parse(Console.ReadLine());

        while (senha != senhaValida)
        {
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");
        Console.ReadLine();
    }
}