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
        double areaTriangulo = A * C / 2;
        double areaCirculo = 3.14159 * (C * C);
        double areaTrapezio = (A + B) * C / 2;
        double areaQuadrado = B * B;
        double areaRetangulo = A * B;
        Console.WriteLine("TRIANGULO: {0:F3}", areaTriangulo);
        Console.WriteLine("CIRCULO: {0:F3}", areaCirculo);
        Console.WriteLine("TRAPEZIO: {0:F3}", areaTrapezio);
        Console.WriteLine("QUADRADO: {0:F3}", areaQuadrado);
        Console.WriteLine("RETANGULO: {0:F3}", areaRetangulo);
    }

}
