using System;

public class Fantasminhas{
    public string habilidade;
    public string nick;
    public string cor;

    public void GerarFantasma(){
        Console.WriteLine($"Nick: {nick}.\nHabilidade: {habilidade}.\nCor: {cor}.");
    }
    public void Mover(string parametro){
        Console.WriteLine($"O fantasminha {nick} se moveu para {parametro}.");
    }
}

class Program{
    public static void Main(){
        Fantasminhas f1 = new Fantasminhas();
        f1.nick = "Ghostin";
        f1.habilidade = "Atravessar paredes";
        f1.cor = "Roxa";
        f1.GerarFantasma();
        f1.Mover("cima");
    }
}