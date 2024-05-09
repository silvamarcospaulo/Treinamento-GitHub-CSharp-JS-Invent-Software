using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class URI
{

    static void Main(string[] args)
    {
        string input;
        List<string> inputs = new List<string>();

        bool inputNull;

        while (!String.IsNullOrEmpty(input = Console.ReadLine()))
        {

            inputs.Add(input);
        }

        foreach (string s in inputs)
        {

            byte[] ASCIIvalues = (Encoding.ASCII.GetBytes(s));
            Dictionary<int, int> repeticoes = new Dictionary<int, int>();

            foreach (var c in ASCIIvalues)
            {

                if (repeticoes.ContainsKey(c))
                {
                    repeticoes[c] = (repeticoes[c] + 1);
                }
                else
                {
                    repeticoes.Add(c, 1);
                }
            }

            var repeticoesOrdenadas = repeticoes.OrderBy(a => a.Value).ThenByDescending(a => a.Key);

            foreach (var v in repeticoesOrdenadas)
            {
                Console.WriteLine("{0} {1}", v.Key, v.Value);
            }

            if (s != inputs.Last())
            {
                Console.WriteLine("");
            }

            repeticoes.Clear();
        }

    }
}