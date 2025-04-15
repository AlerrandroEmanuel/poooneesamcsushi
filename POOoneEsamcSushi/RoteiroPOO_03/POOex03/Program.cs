using System;

public interface IVeiculo{
    void Mover();
}

public class Carro : IVeiculo{
    public void Mover(){
        Console.WriteLine("O carro está se movendo");
    }
}

public class Bicicleta : IVeiculo{
    public void Mover(){
        Console.WriteLine("A bicicleta está se movendo");
    }
}


class Program{
    static void Main(){
        IVeiculo veiculo1 = new Carro();
        IVeiculo veiculo2 = new Bicicleta();

        veiculo1.Mover();
        veiculo2.Mover();
    }
}