using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c, d;
        string entrada;

        entrada =Console.ReadLine();
        a = int.Parse(entrada);

        entrada = Console.ReadLine();
        b = int.Parse(entrada);

        entrada = Console.ReadLine();
        c = int.Parse(entrada);

        entrada = Console.ReadLine();
        d = int.Parse(entrada);

        Console.WriteLine($"DIFERENCA = {a * b - c * d}");

    }

}
