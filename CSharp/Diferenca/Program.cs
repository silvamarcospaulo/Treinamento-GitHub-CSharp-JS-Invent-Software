using System;

class URI
{

    static void Main(string[] args)
    {

        int A, B, C, D;
        //Console.WriteLine("Digite o valor para A: ");
        A = int.Parse(Console.ReadLine());
        //Console.WriteLine("Digite o valor para B: ");
        B = int.Parse(Console.ReadLine());
        //Console.WriteLine("Digite o valor para C: ");
        C = int.Parse(Console.ReadLine());
        // Console.WriteLine("Digite o valor para D: ");
        D = int.Parse(Console.ReadLine());
        int resultado = A * B - C * D;
        Console.WriteLine($"DIFERENCA = {resultado}");

    }

}