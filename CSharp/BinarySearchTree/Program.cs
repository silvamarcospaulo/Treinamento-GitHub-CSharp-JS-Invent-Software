using System;
using System.Linq;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        int C;
        string stringEntrada;

        stringEntrada = Console.ReadLine();
        C = int.Parse(stringEntrada);

        for(int i = 1;C >= i; i++)
        {
            stringEntrada = Console.ReadLine();

            string[] arrayEntrada;

            stringEntrada = Console.ReadLine();
            arrayEntrada = stringEntrada.Split(' ');

            Dictionary<int, int> Arvore = new Dictionary<int, int>();

                
            foreach(string str in arrayEntrada)
                AdicionaArvore(Arvore, int.Parse(str), 1);

            Console.WriteLine($"Case {i}:");
            Console.Write("Pre.: ");

            Preorder(Arvore, 1, Arvore.Count) ;
            Console.WriteLine();

            Console.Write("In..: ");
            Inorder(Arvore, 1, Arvore.Count);
            Console.WriteLine();

            Console.Write("Post: ");
            Postorder(Arvore, 1);
            Console.WriteLine();


        }

       
    }

    static public void AdicionaArvore(Dictionary<int, int> arvore, int valor, int i)
    {
        if(arvore.ContainsKey(i) == false)
        {
            arvore.Add(i, valor);
            return;
        }

        if (arvore[i] > valor)
            AdicionaArvore(arvore, valor, i * 2);
        else
            AdicionaArvore(arvore, valor, i * 2 + 1);
    }

    static public void Preorder(Dictionary<int, int> arvore,int i, int numeroEspacos)
    {
        if (arvore.ContainsKey(i) == false)
            return;

        Console.Write($"{arvore[i]}");
        if (numeroEspacos > 0)
        {
            Console.Write(' ');
            numeroEspacos--;
        }

        Preorder(arvore, i * 2,numeroEspacos);
        Preorder(arvore, i * 2 + 1,numeroEspacos);
    }
    static public void Inorder(Dictionary<int, int> arvore,int i, int numeroEspacos)
    {
         if (arvore.ContainsKey(i) == false)
            return;

        Inorder(arvore, i * 2,numeroEspacos);

        Console.Write($"{arvore[i]}");
        if (numeroEspacos > 0)
        {
            Console.Write(' ');
            numeroEspacos--;
        }
        Inorder(arvore, i * 2 + 1,numeroEspacos);

       
    }
    static public void Postorder(Dictionary<int, int> arvore,int i)
    {
         if (arvore.ContainsKey(i) == false)
            return;

        Postorder(arvore, i * 2);
        Postorder(arvore, i * 2 + 1);

        Console.Write($"{arvore[i]}");
        if (i != 1)
            Console.Write(' ');
    }
}