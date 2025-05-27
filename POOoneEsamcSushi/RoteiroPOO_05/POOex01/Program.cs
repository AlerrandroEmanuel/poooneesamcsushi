using System;


class Program{
    
    static void Main(){

        double[] numeros = new double[5];
        double number;
        int i;

        Console.WriteLine("\nDigite a seguir 5 números decimais com vírgula:(após cada número decimal digitado tecle enter)");

        for ( i=0; i<=4; i++){
            numeros[i] = double.Parse(Console.ReadLine());
        }

        for ( i=0; i<5; i++){

            number = numeros[i];

            double roundnumber = Math.Round(number);
            double rounddownnumber = Math.Floor(number);
            double roundupnumber = Math.Ceiling(number);
            double truncatenumber = Math.Truncate(number);

            Console.WriteLine($"\nNumero original digitado: {number}\nNumero arredondado: {roundnumber}\nNumero arredondado para baixo: {rounddownnumber}\nNumero arredondado para cima: {roundupnumber}\nNumero com truncamento: {truncatenumber}\n");

        }
    }
}

