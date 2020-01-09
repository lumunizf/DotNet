public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo = 100;

    // Toda fun��o representa uma a��o, deve sempre come�ar com letra mai�scula e verbo no infinitivo.
    // E sempre ter um retorno, sen�o n�o compila.
    //Fun��o -> Retorna um valor
    public bool Sacar(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }
        this.Saldo -= valor;
        return true;     
    }

    // M�todo -> N�o retorna um valor
    public void Depositar(double valor)
    {
        //Usamos a refer�ncia "this" dentro de um m�todo para acessar seus atributos
        this.Saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.Saldo < valor)
        {
            return false;
        }
        this.Saldo -= valor;
        contaDestino.Depositar(valor);
        return true;   
    }
}