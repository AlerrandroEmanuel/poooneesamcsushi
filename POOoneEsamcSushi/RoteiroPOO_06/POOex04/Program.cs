using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem)
    {
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade:");

        string entrada = Console.ReadLine();

        try
        {
            int idade = int.Parse(entrada);
            conferiridade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, digite um número inteiro válido.");
        }
    }


    static void conferiridade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Idade menor que 18 anos. Acesso negado.");
        }

        Console.WriteLine("Acesso permitido.");
    }
}
