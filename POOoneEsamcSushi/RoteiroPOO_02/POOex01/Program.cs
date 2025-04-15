using System;

class Produto{
    
    private string nome;
    private decimal preco;

    public string Nome{
        get{return nome;}
        set{this.nome = value;}
    }

    public decimal Preco{
        get{return preco;}
        set{this.preco = value;}
    }

    public Produto(string nomeProduto, decimal precoProduto){
        Nome = nomeProduto;
        Preco = precoProduto;
    }

    public void ExibirDetalhes(){
        Console.WriteLine($"Nome: {Nome}.\nPreço: {Preco}.");
    }
}

class Program{
    
    static void Main(){
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.Preco = -200;
    }
}