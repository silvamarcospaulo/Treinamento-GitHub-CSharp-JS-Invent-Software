using System;

class URI
{

    static void Main(string[] args)
    {
        string entrada;
        int numeroGritos = 0;
        int temp = 0;
        int total = 0;

        while(numeroGritos != 3)
        {
            entrada = Console.ReadLine();

            if(entrada == "caw caw")
            {
                Console.WriteLine(total);
                total = 0;
                numeroGritos++;
            }
            else
            {
                temp = URI.OlhoParaBin(entrada);
                total += URI.BinParaInt(temp);
            }
        }
    }

    static int OlhoParaBin(string olho)
    {
        int saida = 0;

        for(int i = 0; i < 3;i++)
        {
            if (olho[i] == '*')
            {
                saida *= 10;
                saida += 1;
            }
            else
                saida *= 10;
        }
        return saida;
    }

    static int BinParaInt(int bin)
    {
        int saida = 0;
        int n1;

        for(int i = 0;i < 3;i++)
        {
            n1 = bin / 10;
            n1 = bin - n1 * 10;
            bin /= 10;

            saida += n1*(int)Math.Pow(2, i);
        }

        return saida;
    }
}