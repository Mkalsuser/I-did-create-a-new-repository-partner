using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha um valor inical para o intervalo, considerando que ele segue uma ordem decrescente.");
            int vli = int.Parse(Console.ReadLine());
            Console.WriteLine("escolha um valor final para o intervalo");
            int vlf = int.Parse(Console.ReadLine());
            int resto;
            for (int i = vli; i >= vlf; i= i-2)
            {
                resto = i % 2;
                if (resto == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    i--;
                    Console.WriteLine(i);
                }
            }
        }
    }
}   