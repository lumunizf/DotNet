using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";
            Console.WriteLine(contaDoBruno.Saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.Saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.Saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);

           bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.Saldo);
            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}