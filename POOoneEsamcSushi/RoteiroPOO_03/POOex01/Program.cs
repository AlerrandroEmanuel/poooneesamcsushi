using System;

public class Animal{
    public string nome;
    public void EmitirSom(){
        Console.WriteLine("Som genérico do animal");
    }
}

public class Cachorro : Animal{
    public void latir(){
        Console.WriteLine("Auf Auf\n");
    }
}

public class Gato : Animal{
    public void miar(){
        Console.WriteLine("Meow Meow\n");
    }
}

public class Vaca : Animal{
    public void mugir(){
        Console.WriteLine("Muuuuuuuuuuuuuuuuuuuh\n");
    }
}

class Program{
    static void Main(){
        Cachorro cachorro = new Cachorro();
        cachorro.nome = "Pitoco";
        Console.WriteLine(cachorro.nome);
        cachorro.EmitirSom();
        cachorro.latir();

        Gato gato = new Gato();
        gato.nome = "Pretin";
        Console.WriteLine(gato.nome);
        gato.EmitirSom();
        gato.miar();

        Vaca vaca = new Vaca();
        vaca.nome = "Mimosa";
        Console.WriteLine(vaca.nome);
        vaca.EmitirSom();
        vaca.mugir();
    }
}

