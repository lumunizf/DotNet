public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo = 100;

    // Toda função representa uma ação, deve sempre começar com letra maiúscula e verbo no infinitivo.
    // E sempre ter um retorno, senão não compila.
    //Função -> Retorna um valor
    public bool Sacar(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }
        this.Saldo -= valor;
        return true;     
    }

    // Método -> Não retorna um valor
    public void Depositar(double valor)
    {
        //Usamos a referência "this" dentro de um método para acessar seus atributos
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