using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado...";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }

            // Operador lógico OU -> ||
            // Operador lógico E -> &&
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João NÃO pode entrar!");
            }



            Console.ReadLine();
        }
    }
}