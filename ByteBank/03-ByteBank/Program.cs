using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Titular = "Gabriela";
            contaGabriela.Agencia = 863;
            contaGabriela.Numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabriela.Titular = "Gabriela";
            contaGabriela.Agencia = 863;
            contaGabriela.Numero = 863452;

            // As duas contas possuem exatamente os mesmos valores, porém endereços de referência diferentes, por isso o resultado é FALSE
            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta));

            // Neste caso as duas variáveis possuem o mesmo valor
            int idade = 27;
            int idadeDeNovo = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeDeNovo));

            // Atribuindo a referencia da conta da Gabriela para a conta da Gabriela Costa, as duas contas passam a ter o mesmo valor de referência
            contaGabriela = contaGabrielaCosta;
            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta));

            contaGabriela.Saldo = 300;
            Console.WriteLine("O saldo da conta da Gabriela Costa é de: R$ " + contaGabrielaCosta.Saldo);

            Console.ReadLine();
        }
    }
}