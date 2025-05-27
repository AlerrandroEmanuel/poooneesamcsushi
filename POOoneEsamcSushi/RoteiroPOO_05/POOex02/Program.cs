using System.Globalization;
using System;
using System.Collections.Generic;

class Program{

        public static void Main(string[] args){
		Console.WriteLine("Digite uma frase com espaços no ínicio e no final e cada separação de palavra usar vírgula:");

		string frase = Console.ReadLine();

		Console.WriteLine("\nIrei tirar os espaços: ");
		Console.WriteLine(frase.Trim());

		Console.WriteLine("\nAgora irei separar-los por virgula:");
		string[] frasesquartejada = frase.Split(',');
		foreach(string esquartejada in frasesquartejada){
			Console.WriteLine(esquartejada.Trim());
		}

		Console.WriteLine("\nAgora irei trocar o 'a' pelo 'o':");
		Console.WriteLine(frase.Replace('a','o'));

		string newfrase = frase.Trim();

		Console.WriteLine("\nA frase escrita começa por 'a'?");
		Console.WriteLine(newfrase.StartsWith('a'));

		Console.WriteLine("\nA frase escrita termina com 'a'?");
		Console.WriteLine(newfrase.EndsWith('a'));
	}
}