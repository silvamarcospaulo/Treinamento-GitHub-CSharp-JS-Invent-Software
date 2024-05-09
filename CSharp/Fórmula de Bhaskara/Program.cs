using System;
using System.Linq;
class URI
{
    static void Main(string[] args)
    {

        double A, B, C;
        string inp = Console.ReadLine();
        double[] valores = inp.Split(' ').Select(x => double.Parse(x)).ToArray();
        A = valores[0];
        B = valores[1];
        C = valores[2];

        B = B * (-1);
        double delta = (B * B) - 4 * A * C;
        if (A == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
            return;
        }
        double raizMin = (B - Math.Sqrt(delta)) / (2 * A);
        double raizMax = (B + Math.Sqrt(delta)) / (2 * A);
        Console.WriteLine("R1 = {0:F5}", raizMax);
        Console.WriteLine("R2 = {0:F5}", raizMin);

    }
}