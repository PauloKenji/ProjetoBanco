public class Conta
{
    public int Codigo { get;}
    public double Saldo { get; private set;}

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }  

    public void Sacar(double valor)
    {
        VerificarSaldo(valor);   
        ValidarValores(valor);

        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        ValidarValores(valor);

        Saldo += valor;
    }

    public void Transferir(Conta conta, double valor)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }

    private void ValidarValores(Double valor)
    {
        if(valor <= 0) throw new ArgumentException("Valor deve ser maior que zero");
    }

    private void VerificarSaldo(Double valor)
    {
        if(valor > Saldo) throw new ArgumentException("Valor não pode ser maior que o saldo");
    }
}