using System;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Collections.Generic;
class URI
{   
    static void Main(string[] args)
    {
        int linhas = int.Parse(Console.ReadLine());
        int[] valores = new int[linhas];
        for (int i = 0; i < linhas; i++)
        {
            int entrada = int.Parse(Console.ReadLine());
            valores[i] = entrada;
        }

        var pares = new List<int>();
        var impares = new List<int>();
        int contadorPar = 0;
        int contadorImpar = 0;
        for (int i = 0; i < valores.Length ; i++)
        {
            if (valores[i] % 2 == 0) { pares.Add(valores[i]);}
            else { impares.Add(valores[i]);}
        }
        // ordernar o array pares em ordem crescente
        
        impares.Sort();
        pares.Sort();
        impares.Reverse();

        for (int i = 0; i < pares.Count; i++)
        {
            if(pares[i] != 0) { Console.WriteLine(pares[i]); }
            
        }
        for (int i = 0; i < impares.Count; i++)
        {
            if (impares[i] != 0) { Console.WriteLine(impares[i]); }
            
        }




    }
}
