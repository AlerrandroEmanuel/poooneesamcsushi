using System;

class Program
{
    static void Main()
    {
        float temperatura = lertemperaturagraucelsius();
        Console.WriteLine($"Temperatura válida: {temperatura} °C");
    }

    static float lertemperaturagraucelsius()
    {
        while (true)
        {
            Console.WriteLine("Digite a temperatura em Celsius:");

            string entrada = Console.ReadLine();

            try
            {
                float temp = ConverterParaCelsius(entrada);
                return temp; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido. Por favor, digite um número válido (ex: 25.5).");
            }
            finally
            {
                Console.WriteLine("Programa concluído.\n");
            }
        }
    }

    static float ConverterParaCelsius(string entrada)
    {
        if (!float.TryParse(entrada, out float resultado))
        {
            throw new FormatException("Entrada inválida para temperatura.");
        }
        return resultado;
    }
}