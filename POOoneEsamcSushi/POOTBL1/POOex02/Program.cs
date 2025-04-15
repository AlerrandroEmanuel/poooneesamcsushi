using System;

class Program {

  class Pessoa{
    public string Nome;
  }
  
  public static void Main (string[] args) {

    Pessoa p1 = new Pessoa();
    p1.Nome = "Alerrandro";
    Pessoa p2 = p1;
    p2.Nome = "Yassushi";

    Console.WriteLine(p1.Nome);
    Console.WriteLine(p2.Nome);
    
  }
}