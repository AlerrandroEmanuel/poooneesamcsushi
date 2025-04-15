using System;

public class Item {
    public int Produto{get;set;}
    public void Add(){
        Console.WriteLine("Item adicionado ao pedido");
    }
}

public class Pedido{
    
    private Item item;

    public Pedido(){
        item = new Item();
    }

    public void AddItem(){
        Console.WriteLine("Um item");
        item.Add();
    }
}


class Program{
    static void Main(){
        Pedido pedido = new Pedido();
        pedido.AddItem();
    }
}