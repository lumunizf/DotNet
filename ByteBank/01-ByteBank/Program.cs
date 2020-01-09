using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Titular = "Gabriela";
            contaGabriela.Agencia = 863;
            contaGabriela.Numero = 863452;
            contaGabriela.Saldo = 100;

            Console.WriteLine(contaGabriela.Titular);
            Console.WriteLine("Agência: " + contaGabriela.Agencia);
            Console.WriteLine("Número: " + contaGabriela.Numero);
            Console.WriteLine("Saldo: " + contaGabriela.Saldo);

            contaGabriela.Saldo += 200;
            Console.WriteLine("Saldo: " + contaGabriela.Saldo);

            Console.ReadLine();
        }
    }
}
