using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;

            Console.WriteLine("Digite o número inicial:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número final:");
            b = int.Parse(Console.ReadLine());
            if (a > b)

            {
                int t = a;
                a = b;
                b = t;
            }

            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 1)
                {
                    c++;
                }
            }
            Console.WriteLine("o tanto de números ímpares entre " + a + " e " + b + ": " + c);
            Console.ReadKey();
        }
    }
}
