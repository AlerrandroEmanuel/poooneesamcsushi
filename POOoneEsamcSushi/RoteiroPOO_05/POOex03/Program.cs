using System.Globalization;
using System;
using System.Collections.Generic;


class Program{
    public static void Main(string[] args){
		Console.WriteLine("Digite seu nome:");
		string nome = Console.ReadLine();

		Console.WriteLine("\nAgora escreva a data e hora no formato dd/MM/yyyy HH:mm para um compromisso:");
		string data = Console.ReadLine();

		DateTime compromisso;
		DateTime.TryParseExact( data, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out compromisso);

		DateTime hoje = DateTime.Now;
		Console.WriteLine($"Hoje é: {hoje}");

		TimeSpan diastocompromisso = compromisso - hoje;

		int diadiferenca = (int)Math.Ceiling(diastocompromisso.TotalDays);

		string diasemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));
		
		string mensagem = string.Format("Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3}",nome,diadiferenca,diasemana,compromisso.ToString("dd/MM/yyyy 'às' HH:mm"));

		Console.WriteLine("\n"+ mensagem);
	}
}

