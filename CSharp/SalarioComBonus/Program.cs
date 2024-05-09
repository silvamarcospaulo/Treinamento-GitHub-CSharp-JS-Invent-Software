using System;

class URI
{

    static void Main(string[] args)
    {

        String nomeVendedor = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());

        Console.WriteLine("TOTAL = R$ {0:F2}", salario + (0.15 * vendas));
    }

}