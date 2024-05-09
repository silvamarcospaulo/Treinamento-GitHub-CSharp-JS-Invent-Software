using System;

class URI
{

    static void Main(string[] args)
    {

        int[] input = new int[4];
        for (int i = 0; i < 4; i++)
        {
            input[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"DIFERENCA = {input[0] * input[1] - input[2] * input[3]}");
    }
}