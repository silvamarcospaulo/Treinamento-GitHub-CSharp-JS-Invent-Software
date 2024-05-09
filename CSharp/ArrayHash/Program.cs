using System;
using System.Linq;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        string strEntrada = Console.ReadLine();

        Dictionary<char, int> Alfabeto = CriaAlfabeto();

        int N = int.Parse(strEntrada);
        int L, i, soma = 0;



        for(;N > 0; N--)
        {
            strEntrada = Console.ReadLine();
            L = int.Parse(strEntrada);
            
            for(int j = 0; j < L; j++)
            {
                i = 0;
                strEntrada = Console.ReadLine();
                foreach(char c in strEntrada)
                {
                    soma += Alfabeto[c] + i + j;
                    i++; 
                }
            }

            Console.WriteLine(soma);
            soma = 0;
        }
    }

    public static Dictionary<char,int> CriaAlfabeto()
    {
        Dictionary<char, int> Alfabeto = new Dictionary<char, int>();

        for(int i = 0; i < 26;i++)
            Alfabeto.Add((char)('A'+i), i);

        return Alfabeto;
    }
 }