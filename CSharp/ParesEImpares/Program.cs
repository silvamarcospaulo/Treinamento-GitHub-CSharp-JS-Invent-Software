using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        int input;

        List<int> inputs = new List<int>();

        input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            inputs.Add(Convert.ToInt32(Console.ReadLine()));
        }

        List<int> impar = new List<int>();
        List<int> par = new List<int>();

        foreach (int i in inputs)
        {

            if (i % 2 == 0)
            {
                par.Add(i);
            }
            else
            {
                impar.Add(i);
            }
        }

        var separado = new List<int>(par.OrderBy(n => n));
        separado.AddRange(impar.OrderByDescending(n => n));

        foreach (int i in separado)
        {
            Console.WriteLine(i);
        }
    }
}