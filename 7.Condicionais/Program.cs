using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Execução do Projeto 7. Condicionais. " + "\n");

            int idadeJoao = 18;
            int acompanhado = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Possui mais de 18 anos de idade, Pode Entrar. ");
            }
            else
            {
                if (acompanhado >= 2)
                {
                    Console.WriteLine("Menor acompanhado, Pode Entrar!");
                }
                else
                {

                    Console.WriteLine("Menor de idade, Não pode entra);                                                                                              ar. ");
                }

            }

            Console.ReadLine();
        }
    }
}
