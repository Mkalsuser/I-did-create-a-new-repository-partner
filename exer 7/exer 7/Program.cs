using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int l = 100;
            int i;

            if (l > 100)
            {
                l = 100;
            }

            for (i = 10; i <= l; i += 10)
            {
                Console.WriteLine("multiplo de 10: " + i);
            }
            
            Console.ReadKey();
        }
    }
}