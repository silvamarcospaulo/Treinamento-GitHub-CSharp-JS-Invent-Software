using System;
using System.Collections;

class URI
{

    static void Main(string[] args)
    {
        string input;
        int[] numerosCorvo = new int[3];
        int numeroLoteria = 0;
        int i = 0;

        for (int contGrito = 0; contGrito < 3;)
        {
            input = Console.ReadLine();

            if (input == "--*")
            {
                numeroLoteria = numeroLoteria + 1;
            }
            else if (input == "-*-")
            {
                numeroLoteria = numeroLoteria + 2;

            }
            else if (input == "-**")
            {
                numeroLoteria = numeroLoteria + 3;

            }
            else if (input == "*--")
            {
                numeroLoteria = numeroLoteria + 4;
            }
            else if (input == "*-*")
            {
                numeroLoteria = numeroLoteria + 5;

            }
            else if (input == "**-")
            {
                numeroLoteria = numeroLoteria + 6;

            }
            else if (input == "***")
            {
                numeroLoteria = numeroLoteria + 7;

            }
            else if (input == "caw caw")
            {
                contGrito++;
                numerosCorvo[i] = numeroLoteria;
                numeroLoteria = 0;
                i++;
            }
        }

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine("{0}", numerosCorvo[i]);
        }

    }

}