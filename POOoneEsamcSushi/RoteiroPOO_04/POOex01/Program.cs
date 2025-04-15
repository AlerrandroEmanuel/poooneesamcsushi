using System;

class Pagamento{
    public virtual void ProcessarPagamento(){
        Console.WriteLine("Tipo de pagamento:");
    }
}

class CartaoCredito : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento via Cartão de Crédito");
    }
}

class BoletoBancario : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento via Boleto Bancário");
    }
}

class Pix : Pagamento{
    public override void ProcessarPagamento(){
        Console.WriteLine("Pagamento via Pix");
    }
}

class Program{
    
    static void Main(){
        Pagamento pagamento1 = new CartaoCredito();
        Pagamento pagamento2 = new BoletoBancario();
        Pagamento pagamento3 = new Pix();

        pagamento1.ProcessarPagamento();
        pagamento2.ProcessarPagamento();
        pagamento3.ProcessarPagamento();
    }
}