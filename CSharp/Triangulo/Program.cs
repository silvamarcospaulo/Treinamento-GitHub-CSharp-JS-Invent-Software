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

        if ((Math.Abs(B - C) < A && A < (B + C)) && (Math.Abs(A - C) < B && B < (A + C)) && (Math.Abs(A - B) < C && C < (A + B)))
        {
            double perimetro = A + B + C;
            Console.WriteLine("Perimetro = {0:F1}", perimetro);

        }
        else
        {
            double area = (A + B) * C / 2;
            Console.WriteLine("Area = {0:F1}", area);
        }

    }
}