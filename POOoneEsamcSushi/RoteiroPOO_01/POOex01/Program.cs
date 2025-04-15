using System;

public class Pessoa{
    public string nome;
    public int idade;
    public string cargo;

    public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos e meu cargo é {cargo}.");
    }

    public void Salario(){
        if(cargo == "Gerente"){
            Console.WriteLine($"Seu salário é de R$10.000,00.");
        }else if(cargo == "Desenvolvedor"){
            Console.WriteLine($"Seu salário é de R$5.000,00.");
        }else if(cargo == "Estagiário"){
            Console.WriteLine($"Seu salário é de R$100,00.");
        }
    }
}

class Program{
    public static void Main(){
        Pessoa p1 = new Pessoa();
        p1.idade = 30;
        p1.nome = "Joao";
        p1.cargo = "Gerente";
        p1.Apresentar();
        p1.Salario();

        Pessoa p2 = new Pessoa();
        p2.idade = 24;
        p2.nome = "Jubiloide";
        p2.cargo = "Desenvolvedor";
        p2.Apresentar();
        p2.Salario();

        Pessoa p3 = new Pessoa();
        p3.idade = 21;
        p3.nome = "Alerrandro";
        p3.cargo = "Estagiário";
        p3.Apresentar();
        p3.Salario();
    }
}

