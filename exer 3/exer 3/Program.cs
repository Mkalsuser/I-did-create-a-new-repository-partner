class Program
{
    static void Main()
    {
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        int i = 0;
        do
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            i++;
        } while (i <= 10);

    }
}