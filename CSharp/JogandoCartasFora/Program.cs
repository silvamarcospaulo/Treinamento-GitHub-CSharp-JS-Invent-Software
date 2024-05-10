using System;
using System.Security.Cryptography.X509Certificates;

class URI
{

    static void Main(string[] args)
    {
        List<int> cartas = new List<int>();

        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Digite o valor: ");
            int valor = int.Parse(Console.ReadLine());
            if (valor == 0)
            {
                i = 50;

            }
            else { cartas.Add(valor); }


        }
        int n = cartas.Count;
        List<int> cartasDescartadas = new List<int>();
        int[] cartasArray = cartas.ToArray();

        for (int i = 0; i < cartasArray.Length; i++)
        {
            Console.WriteLine($"Posição{i} - {cartasArray[i]}");
        }




    }



}