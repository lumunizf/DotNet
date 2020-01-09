using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            // Índice de rendimento da poupança: 0.36% = 0.0036
            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contadorMes +" meses, você terá R$ " + valorInvestido);
                          
                contadorMes++;

                // três outras formas de escrever uma mesma expressão:
                // contadorMes = contadorMes + 1; ou
                // contadorMes += 1; (usado quando é contado de 2 em 2 em diante) ou
                // contadorMes++; (usado quando é contado de 1 em 1)
            }

            Console.ReadLine();
        }
    }
}