using System;

public interface IVoar{
    void Voar();
}

public interface INadar{
    void Nadar();
}

public class Pato : IVoar, INadar{
    
    public void Voar(){
        Console.WriteLine("\nO pato sabe voar");
    }

    public void Nadar(){
        Console.WriteLine("O pato sabe nadar\n");
    }
}

public class Aguia : IVoar, INadar{
    
    public void Voar(){
        Console.WriteLine("A águia sabe voar");
    }

    public void Nadar(){
        Console.WriteLine("A águia não sabe nadar\n");
    }
}

public class Peixe : IVoar, INadar{
    
    public void Voar(){
        Console.WriteLine("O peixe não sabe voar");
    }

    public void Nadar(){
        Console.WriteLine("O peixe sabe nadar\n");
    }
}

class Program{
    
    static void Main(){
        
        IVoar voar1 = new Pato();
        INadar nadar1 = new Pato();
        IVoar voar2 = new Aguia();
        INadar nadar2 = new Aguia();
        IVoar voar3 = new Peixe();
        INadar nadar3 = new Peixe();

        voar1.Voar();
        nadar1.Nadar();
        voar2.Voar();
        nadar2.Nadar();
        voar3.Voar();
        nadar3.Nadar();

    }
}