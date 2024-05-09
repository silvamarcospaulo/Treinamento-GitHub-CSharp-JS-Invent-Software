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

        double delta = (b * b) - (4 * a * c);

        if ((delta <= 0) || (a == 0))
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = {0:F5}", (-b + Math.Sqrt(delta)) / (2 * a));
            Console.WriteLine("R2 = {0:F5}", (-b - Math.Sqrt(delta)) / (2 * a));
        }

    }

}