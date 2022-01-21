public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;
    
    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            System.Console.WriteLine("Saque não disponivel");
            return false;
        }

        System.Console.WriteLine("Saque efetuado");
        this.saldo -= valor;
        return true;
        
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }


    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            System.Console.WriteLine("Transação não efetuada");
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        System.Console.WriteLine("Transação efetuada com sucesso");
        return true;
        
    }


}