using System;

class Program {

  public static void Main (string[] args) {

    Console.Write("\nDigite um numero:");
    string variable = Console.ReadLine();
    bool number = int.TryParse(variable, out int numero);

    if(number){ 
    Console.WriteLine("Que obediente! Fez o que mandei >.< <3\n"); 
    }else{ 
    Console.WriteLine("Voce nao digitou um numero, reinicia de novo e digite um numero |.`_´.|\n");
    }

  }
}