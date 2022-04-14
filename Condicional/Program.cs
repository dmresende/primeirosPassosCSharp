using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do Exercicio Condicionais...");

            int idade = 17;
            int acompanhante = 1;

            if(idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos!!");
                Console.WriteLine("Seja Bem Vindo!");
            } else
            {
                if (acompanhante >= 3) 
                {
                    Console.WriteLine("Pode entrar, com seu acompanhante, Bem vindo!");

                } else
                {

                Console.WriteLine("Infelizmente você não pode entrar! ");    

                }
                
            }


            Console.Read();
        }
    }
}
