using System;

class URI
{

    static void Main(string[] args)
    {

        string nome;
        double salarioFixo;
        double vendas;
        nome = Console.ReadLine();
        salarioFixo = double.Parse(Console.ReadLine());
        vendas = double.Parse(Console.ReadLine());
        double comissao = 0.15 * vendas;
        double salarioFinal = salarioFixo + comissao;
        Console.WriteLine("TOTAL = R$ {0:F2}", salarioFinal);

    }

}