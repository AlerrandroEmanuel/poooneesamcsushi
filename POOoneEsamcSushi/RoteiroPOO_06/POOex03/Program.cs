using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");

        string numero = Console.ReadLine();

        try
        {
            int number = int.Parse(numero);
            Console.WriteLine("Você digitou o número: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }
}
