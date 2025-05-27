using System.Globalization;
using System;
using System.Collections.Generic;

class Program
    {
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nomeproduto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeproduto))
                throw new ArgumentException("O nome do produto está em branco.");

            Console.Write("Digite o preço do produto: ");
            string precoproduto = Console.ReadLine();

            if (!decimal.TryParse(precoproduto, out decimal preco))
                throw new ArgumentException("Preço não existe. Digite um número que vale.");

            if (preco <= 0)
                throw new ArgumentException("O preço do produto tem que ser maior que zero.");

            Console.WriteLine($"Produto cadastrado: {nomeproduto} - R$ {preco:F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Ocorreu um erro inesperado.");
        }
        finally
        {
            Console.WriteLine("Programa finalizado.");
        }
    }
}

