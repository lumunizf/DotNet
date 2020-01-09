using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // Tipo char -> sempre declarado com aspas simples
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            // Casting para converter numero em letra
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            // Casting para converter uma expressão com numeros em letra
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            // Tipo string -> sempre declarado com aspas duplas
            string titulo = "Curso de CSharp";
            Console.WriteLine(titulo);

            string titulo2020 = "Curso de CSharp " + 2020;
            Console.WriteLine(titulo2020);

            // O C# permite strings vazias, mas não do tipo char
            string vazia = "";

            // Criar uma lista com strings
            string cursosProgramacao = 
@"- .NET
- Java
- Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execução acabou. Tecle <ENTER> para sair...");
            Console.ReadLine();
        }
    }
}
