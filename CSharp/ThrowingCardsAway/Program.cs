using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class URI
{

    static void Main(string[] args)
    {
        string stringEntrada;
        int intEntrada;
        int j;
        List<int> Baralho = new List<int>();
        List<int> Descarte = new List<int>();
        
        while(true)
        {
            stringEntrada = Console.ReadLine();
            intEntrada = int.Parse(stringEntrada);

            if (intEntrada == 0)
                break;


            for (int i = 1; i <= intEntrada; i++)
                Baralho.Add(i);

            while(Baralho.Count != 1)
            {
                Descarte.Add(Baralho.First());
                Baralho.RemoveAt(0);
                Baralho.Add(Baralho.First());
                Baralho.RemoveAt(0);
            }

            Console.Write("Discarded cards: ");
            while(true)
            {
                if (Descarte.Count == 0)
                    break;

                Console.Write(Descarte.First());
                Descarte.RemoveAt(0);

                if (Descarte.Count != 0)
                    Console.Write(", ");
            }
            Console.WriteLine();
            Console.Write("Remaining cards: ");
            while(true)
            {
                if (Baralho.Count == 0)
                    break;

                Console.Write(Baralho.First());
                Baralho.RemoveAt(0);

                if (Baralho.Count != 0)
                    Console.Write(", ");
            }
            Console.WriteLine();

            Baralho.Clear();
            Descarte.Clear();
        }
       
    }
}