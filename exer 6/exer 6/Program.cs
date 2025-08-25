using System;

class Program
{
    static void Main()
    {
        int s = 0;
        int n, m;
        int c = 1;

        while (c <= 10)
        {
            do
            {
                Console.Write($"coloque notas de 0 ate 10: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 10)
                {
                    Console.WriteLine("ja falei que e de 0 ate 10 meu mano: ");
                }

            } while (n < 0 || n > 10);

            s += n;
            c++;
        }

        m = s / 10;
        Console.WriteLine($"sua media é: " + m);
        Console.ReadKey();
    }

}
