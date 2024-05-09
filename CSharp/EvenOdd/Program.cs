using System;
using System.Linq;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        int numeroEntradas;
        int entradaNumero;
        string entradaString;
      
        List<int> numeros = new List<int>();

        entradaString = Console.ReadLine();
        numeroEntradas = int.Parse(entradaString);
        
        for(;numeroEntradas > 0;numeroEntradas--) 
        {
            entradaString = Console.ReadLine();
            numeros.Add(int.Parse(entradaString));
        }

        List<int> numerosPar = (from num in numeros
                               where num % 2 == 0
                               orderby num ascending
                               select num).ToList();

        List<int> numerosImpar = (from num in numeros
                                  where num % 2 == 1
                                  orderby num descending
                                  select num).ToList();

        foreach (var num in numerosPar)
            Console.WriteLine(num);

        foreach (var num in numerosImpar)
            Console.WriteLine(num);
     }
 }