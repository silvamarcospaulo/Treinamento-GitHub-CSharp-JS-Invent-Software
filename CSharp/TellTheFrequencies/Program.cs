using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class URI
{

    static void Main(string[] args)
    {
        string stringEntrada;

        stringEntrada = Console.ReadLine();
        
        while(stringEntrada != null)
        {
            char[] arrayChar = stringEntrada.ToCharArray();
            char[] arrayDistinto = arrayChar.GroupBy(c => c)
                                            .OrderBy(g => g.Count())
                                            .ThenBy(g => g.Key)
                                            .SelectMany(g => g)
                                            .Distinct()
                                            .ToArray(); 

            foreach(char c in arrayDistinto)
            {
                int total = (from d in arrayChar
                             where d == c
                             select d).Count();
                Console.WriteLine((int)c + " " + total);
            }
            Console.WriteLine();
         
            stringEntrada = Console.ReadLine();  
        }
        
       
    }
}
