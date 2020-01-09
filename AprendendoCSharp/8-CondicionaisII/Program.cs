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
            Console.WriteLine("Executando projeto 8 - Condicionais II");

            int idadeJoao = 16;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            // Operador lógico OU -> ||
            // Operador lógivo E -> &&
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar!");
            }
            else
            {
                Console.WriteLine("João NÃO pode entrar!");
            }



            Console.ReadLine();
        }
    }
}