using System;
using System.Collections;

class URI
{

    static void Main(string[] args)
    {

        int input = Convert.ToInt32(Console.ReadLine());

        Hashtable codigosDdd = new Hashtable();

        codigosDdd.Add(Convert.ToInt32(61), "Brasilia");
        codigosDdd.Add(Convert.ToInt32(71), "Salvador");
        codigosDdd.Add(Convert.ToInt32(11), "Sao Paulo");
        codigosDdd.Add(Convert.ToInt32(21), "Rio de Janeiro");
        codigosDdd.Add(Convert.ToInt32(32), "Juiz de Fora");
        codigosDdd.Add(Convert.ToInt32(19), "Campinas");
        codigosDdd.Add(Convert.ToInt32(27), "Vitoria");
        codigosDdd.Add(Convert.ToInt32(31), "Belo Horizonte");

        if (codigosDdd.ContainsKey(input))
        {
            Console.WriteLine($"{codigosDdd[input].ToString()}");
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }

    }

}