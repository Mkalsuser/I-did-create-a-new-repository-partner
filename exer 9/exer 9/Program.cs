using System;

class Program
{
    static void Main()
    {
        int pares = 0, impares = 0, positivos = 0, negativos = 0;
        string resposta;

        do
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) pares++;
            else impares++;

            if (numero > 0) positivos++;
            else if (numero < 0) negativos++;

            Console.Write("Deseja encerrar o programa? (S/N): ");
            resposta = Console.ReadLine().ToUpper();
        } while (resposta != "S");

        Console.WriteLine($"\nPares: {pares}\nÍmpares: {impares}\nPositivos: {positivos}\nNegativos: {negativos}");
    }
}
