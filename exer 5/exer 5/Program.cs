using System;

class Program
{
    static void Main()
    {
        int m = 0;

        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 1; i <= 15; i++)
        {
            Console.Write(i + " número: ");
            int n = int.Parse(Console.ReadLine());

            if (n > m)
            {
                m = n;
            }
        }

        Console.WriteLine("O maior número digitado foi: " + m);
        Console.ReadKey();
    }
}