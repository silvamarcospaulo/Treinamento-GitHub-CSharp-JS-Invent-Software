using System;

class URI
{

    static void Main(string[] args)
    {

        string input = Console.ReadLine();

        string[] input_ = input.Split(' ');

        double a = Convert.ToDouble(input_[0]);
        double b = Convert.ToDouble(input_[1]);
        double c = Convert.ToDouble(input_[2]);

        double d = a + b;

        if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
        {
            Console.WriteLine("Perimetro = {0:F1}", (a + b + c));
        }
        else
        {
            Console.WriteLine("Area = {0:F1}", ((a + b) * c) / 2);
        }

    }
}