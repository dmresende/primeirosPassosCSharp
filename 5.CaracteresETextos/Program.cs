using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ëxecutando o projeto 5 - Caracteres e Textos.");

            //aspas simples para char.
            char primeiraLetra = 'a'; 
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia" + 2022;
            Console.WriteLine(titulo);

            // o sinal de @ antes das asoas na string considera os expaços dados no editor;
            string cursosProgramacao = @"
              - .NET;
              - JAVA;
              - C#.";
            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
