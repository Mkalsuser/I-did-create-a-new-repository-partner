using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("Coloque um número para calcular o fatorial:");
            v = int.Parse(Console.ReadLine());
            while (v < 0)
            {
                Console.WriteLine("Não existe fatorial para números negativos. Digite outro número joãozinho:");
                v = int.Parse(Console.ReadLine());
            }
            if (v == 0 || v == 1)
            {
                Console.WriteLine($"O fatorial de " + v + " é 1.");
            }
            else
            {
                int f = 1;
                for (int c = v; c >= 2; c--)
                {
                    f *= c;
                }

                Console.WriteLine($"O fatorial de " + v + " é " + f);
            }
        }
    }
}

