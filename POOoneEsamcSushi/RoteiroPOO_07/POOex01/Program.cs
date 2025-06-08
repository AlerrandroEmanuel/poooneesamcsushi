using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args)
    {
        List<string> compras = new List<string>();

        compras.Add(Console.ReadLine());
        Console.WriteLine($"Total de itens da compra: {compras.Count}");
        foreach (string compra in compras)
        {
            Console.WriteLine($"- {compra}");
        }
        compras.Remove(Console.ReadLine());
        Console.WriteLine($"Total de itens da compra: {compras.Count}");
    }
}