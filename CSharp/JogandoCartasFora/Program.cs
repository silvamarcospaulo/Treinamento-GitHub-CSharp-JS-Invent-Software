using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        List<int> cartas = new List<int>();
        List<int> cartasDescarte = new List<int>();

        int quantidadeCartas;

        List<int> entradas = new List<int>();

        int input;

        while((input = Convert.ToInt32(Console.ReadLine()))  > 0 && input < 51)
        {            
            entradas.Add(input);
        }

        for (int j = 0; j < entradas.Count; j++) { 

            quantidadeCartas = entradas[j];

            for (int i = 1; i <= quantidadeCartas; i++)
            {
                cartas.Add(i);
            }

            for (int i = 0; cartas.Count() > 1; i++)
            {
                if ((i % 2 == 0) || (i == 0))
                {
                    cartasDescarte.Add(cartas[0]);
                    cartas.Remove(cartas[0]);
                }

                if (i % 2 != 0)
                {
                    cartas.Add(cartas.First());
                    cartas.Remove(cartas.First());
                }
            }

            Console.Write("Discarded cards: ");
            foreach (int c in cartasDescarte)
            {
                Console.Write("{0}", c);

                if (c != cartasDescarte[cartasDescarte.Count() - 1])
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\nRemaining card: {0}", cartas.First());

            cartas.Clear();
            cartasDescarte.Clear();
        }
    }
}