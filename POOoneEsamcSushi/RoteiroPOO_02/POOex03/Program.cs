using System;

class Elevador{
    
    private int andarAtual;
    private int totalAndares;

    public int AndarAtual{
        get{return andarAtual;}
        set{this.andarAtual = value;}
    }

    public int TotalAndares{
        get{return totalAndares;}
        set {this.totalAndares = value;}
    }

    public Elevador(int totalAndares){
        andarAtual = 0;
        totalAndares = TotalAndares;
    }

    public void Subir(){
        if (andarAtual >= 0){
            andarAtual = 1 + andarAtual;
        }
        if (andarAtual < 0){
            andarAtual = 0;
        }
    }

    public void Descer(){
        if (andarAtual >= 0){
            andarAtual = andarAtual - 1;
        }
        if (andarAtual < 0){
            andarAtual = 0;
        }
    }
}

class Program{
    
    static void Main(){
        Elevador e = new Elevador(10); // 10 andares
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual); // Deve exibir 2
        e.Descer();
        Console.WriteLine(e.AndarAtual); // Deve exibir 1
        e.Descer();
        e.Descer(); // Deve continuar em 0
        Console.WriteLine(e.AndarAtual);
    }
}