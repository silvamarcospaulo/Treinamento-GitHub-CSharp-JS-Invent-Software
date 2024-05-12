using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


class URI
{

    static void Main(string[] args)
    {
        List<int> cartas = new List<int>();

        for (int i = 0; i < 50; i++)
        {

            int valor = int.Parse(Console.ReadLine());
            if (valor == 0)
            {
                i = 50;

            }
            else { cartas.Add(valor); }


        }
        
        //List<int> cartasDescartadas = new List<int>();
        int[] cartasArray = cartas.ToArray();

        for (int i = 0; i < cartasArray.Length; i++)
        {
            List<int> cartasDescartadas = new List<int>();
            //adiciona os elementos de cada numero ao array temorario
            int[] arrayTemporario = new int[cartasArray[i]]; // array temp com 7 espcaços
            for (int j = 0; j < cartasArray[i]; j++)
            {
                arrayTemporario[cartasArray[i] - (j + 1)] = cartasArray[i] - j;
            }

            //--------------------------------------------------------------------

            for (int h = 0; arrayTemporario.Length > 1; h++)
            {
                // Codigo para jogar o primeiro elemento do array fora : OK

                cartasDescartadas.Add(arrayTemporario[0]);
                for (int i2 = 0; i2 < arrayTemporario.Length - 1; i2++)
                {
                    arrayTemporario[i2] = arrayTemporario[i2 + 1];
                }

                // Redimensionar o tamanho do array : OK

                Array.Resize(ref arrayTemporario, arrayTemporario.Length - 1);

                //mover a que ficou no topo para base
                //
                int temp = arrayTemporario[0];

                for (int i3 = 1; i3 < arrayTemporario.Length; i3++)
                {
                    arrayTemporario[i3 - 1] = arrayTemporario[i3];
                }

                arrayTemporario[arrayTemporario.Length - 1] = temp;
            }
            cartasDescartadas.ToArray();
            Console.Write("Discarded cards: ");
            foreach (int g in cartasDescartadas)
            {
                if (g == cartasDescartadas[cartasDescartadas.Count - 1])
                {
                    Console.Write($" {g}");
                }
                else
                {
                    Console.Write($" {g},");
                }

            }
            Console.WriteLine($"\nRemaining card: {arrayTemporario[0]}");

        }

    }

}

// isso é tudo pepessoal 