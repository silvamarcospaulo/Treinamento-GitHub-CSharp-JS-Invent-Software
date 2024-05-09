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

        double delta = b * b - 4 * a * c;

        if(delta < 0 || a ==0)
            Console.WriteLine("Impossivel calcular");
        else
        {
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a),
                   r2 = (-b - Math.Sqrt(delta)) /( 2 * a);
            Console.WriteLine(string.Format("R1 = {0:0.00000}", r1));
            Console.WriteLine(string.Format("R2 = {0:0.00000}",r2));
        }
        

    }

}