
public class ContaCorrente
{
   public string titular;
   public int agencia;
   public int numero;
   public double saldo = 100;


    //todo nome de função comeca com maiusculo
    //toda funcao deve ser em verbo infinitivo
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }

    }

    public void Depositar (double valor)
    {
        this.saldo += valor;
    }
    
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo<valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
