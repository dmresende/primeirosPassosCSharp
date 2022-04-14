using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ EXERCÍCIO  CARACTERES E TEXTOS ] ");

            //char guarda apenas caracter da tabela ASCII
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            //tem que estar entre parênteses porque o numero é inteiro e estamos forçando a entrada dele no tipo char.
            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = " Alura cursos online de tecnologia " + 2022;
            Console.WriteLine(palavra);



            Console.Read();
        }
    }
}
