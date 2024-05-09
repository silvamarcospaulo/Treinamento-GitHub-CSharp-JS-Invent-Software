using System;

class URI
{

    static void Main(string[] args)
    {

        double[] numeros;

        string entrada;
        string[] entradaArray;

        entrada = Console.ReadLine();
        entradaArray = entrada.Split(' ');

        numeros = Array.ConvertAll(entradaArray, double.Parse);

        double a = numeros[0],
               b = numeros[1],
               c = numeros[2];

        if (a < b + c && b < a + c && c < a + b)
            Console.WriteLine(String.Format("Perimetro = {0:0.0}", a + b + c));
        else
            Console.WriteLine(String.Format("Area = {0:0.0}", (a + b) * c / 2));

    }

}