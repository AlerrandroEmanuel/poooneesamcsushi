using System;

abstract class Funcionario{
    
    public int salario {get; set;}

    public void CalcularSalario(){
        if(salario==10000){
            Console.WriteLine("\nO Gerente ganha R$10000,00 por sua competência em Gerência de Programadores");
        } else if (salario==7000){
            Console.WriteLine("\nO Programador ganha R$7000,00\n");
        }
    }
}

class Gerente : Funcionario{

}

class Programador : Funcionario{

}

class Program{
    
    static void Main(){
        Gerente boss = new Gerente{salario = 10000};
        boss.CalcularSalario();

        Programador programmer = new Programador{salario = 7000};
        programmer.CalcularSalario();
    }
}