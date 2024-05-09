using System;

class URI
{

    static void Main(string[] args)
    {
        double PI = 3.14159;

        double resultado;
        double[] numeros;

        string[] entrada;

        entrada = (Console.ReadLine()).Split(' ');

        numeros = Array.ConvertAll(entrada, double.Parse); //0 =a, 1 = b, 2 = c

        resultado = (double) numeros[0] * numeros[2] / 2;
        Console.WriteLine(String.Format("TRIANGULO: {0:0.000}", resultado));

        resultado = (double)PI * numeros[2] * numeros[2];
        Console.WriteLine(String.Format("CIRCULO: {0:0.000}", resultado));

        resultado = (double)(numeros[0] + numeros[1]) * numeros[2] / 2;
        Console.WriteLine(String.Format("TRAPEZIO: {0:0.000}", resultado));

        resultado = numeros[1] * numeros[1];
        Console.WriteLine(String.Format("QUADRADO: {0:0.000}", resultado));

        resultado = numeros[0] * numeros[1];
        Console.WriteLine(String.Format("RETANGULO: {0:0.000}", resultado));

    }

}