using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13.ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Executando Projeto P13. Encadeamento. ]");

            //forma 1
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;

                    }

                }
                Console.WriteLine();
            }


            //Outra forma
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}


