using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 13 - Comando for encadeado");
            Console.WriteLine();

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******

            // Escrevendo asteriscos com o comando break
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break; // o comando "break" só se comunica com o comando for imediatamente acima dele
                }
                Console.WriteLine();
            }


            // Outra forma de escrever asteriscos com o break
            Console.WriteLine();
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}