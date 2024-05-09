using System;

class URI
{

    static void Main(string[] args)
    {
        string nome;
        double salario, totalVendas;

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        totalVendas = double.Parse(Console.ReadLine());

        Console.WriteLine(string.Format("TOTAL = R$ {0:0.00}", salario + totalVendas*0.15));
        
    }

}