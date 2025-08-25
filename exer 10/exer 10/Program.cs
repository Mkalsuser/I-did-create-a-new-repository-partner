using System;

class Program
{
    static void Main()
    {
        string resposta;

        do
        {
            Console.Write("Digite o código do trabalhador: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            double salario = 0, excesso = 0;

            if (horas > 50)
            {
                excesso = horas - 50;
                salario = 50 * 10 + excesso * 20;
            }
            else
            {
                salario = horas * 10;
            }

            Console.WriteLine($"Código: {codigo}\nSalário total: R$ {salario:F2}\nHoras extras: {excesso}");
            Console.Write("Deseja encerrar o programa? (S/N): ");
            resposta = Console.ReadLine().ToUpper();

        } while (resposta != "S");
    }
}