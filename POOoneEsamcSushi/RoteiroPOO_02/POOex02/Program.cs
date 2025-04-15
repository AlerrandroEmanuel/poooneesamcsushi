using System;

class Carro{
    
    private string modelo;
    private int velocidadeAtual;

    public string Modelo{
        get{return modelo;}
        set{this.modelo = value;}
    }

    public int VelocidadeAtual{
        get{return velocidadeAtual;}
        set {this.velocidadeAtual = value;}
    }

    public Carro(string carroModelo, int carroVelocidadeAtual){
        modelo = carroModelo;
        velocidadeAtual = carroVelocidadeAtual;
    }

    public void Acelerar(int valor){
        if (valor > 0){
            VelocidadeAtual = VelocidadeAtual + valor;
        }
        Console.WriteLine($"Acelerar: {VelocidadeAtual}.");
    }

    public void Frear(int valor){
        if(valor > 0){
            VelocidadeAtual = VelocidadeAtual - valor;
        } if (VelocidadeAtual < 0){
            VelocidadeAtual = 0;
        }

        Console.WriteLine($"Frear: {VelocidadeAtual}.");
    }
}

class Program{
    
    static void Main(){
        Carro c = new Carro("Ferrari",0);
        c.Acelerar(50);
        Console.WriteLine(c.VelocidadeAtual); // Deve exibir 50
        c.Frear(30);
        Console.WriteLine(c.VelocidadeAtual); // Deve exibir 20
        c.Frear(50); // Não pode ficar negativo, deve exibir 0
        Console.WriteLine(c.VelocidadeAtual);
    }
}