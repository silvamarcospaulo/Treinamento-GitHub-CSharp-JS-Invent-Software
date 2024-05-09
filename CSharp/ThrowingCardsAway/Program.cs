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
        int temp;

        Queue<int> Baralho = new Queue<int>();

        while (true)
        {
            stringEntrada = Console.ReadLine();
            intEntrada = int.Parse(stringEntrada);

            if (intEntrada == 0)
                break;

            for (int i = 1; i <= intEntrada; i++)
                Baralho.Enqueue(i);

            Console.Write("Discarded cards: ");
            while (Baralho.Count != 1)
            {
                Console.Write(Baralho.Peek());
                Baralho.Dequeue();

                if (Baralho.Count != 1)
                    Console.Write(", ");
                else
                {
                    Console.WriteLine();
                    break;
                }
                temp = Baralho.Peek();
                Baralho.Dequeue();
                Baralho.Enqueue(temp);
            }
            Console.WriteLine($"Remaining card: {Baralho.Peek()}");

            Baralho.Clear();
        }
    }
}