using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.50;

            // o tipo "int" ocupa 32 bits em memória
            int salarioEmInteiro;
            salarioEmInteiro = (int) salario; // esta conversão se chama "casting"
            Console.WriteLine(salarioEmInteiro);

            // o tipo "long" ocupa mais espaço em memória: 64 bits
            long idade;
            idade = 13000000000; // idade do universo
            Console.WriteLine(idade);

            //  o tipo "short" ocupa 16 bits na memória
            short quantidadeDeProdutos;
            quantidadeDeProdutos = 15000;
            Console.WriteLine(quantidadeDeProdutos);

            // o tipo "float" precisa que seja acrescentado um 'f' no final para que o compilador entenda que se trata de um tipo flutuante.
            // BOA PRÁTICA: declaração de variavel e atribuição de valor na mesma linha.
            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.WriteLine("A execução acabou. Tecle <ENTER> para sair...");
            Console.ReadLine();
        }
    }
}
