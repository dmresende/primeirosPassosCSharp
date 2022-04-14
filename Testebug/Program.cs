using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testebug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Executando Projeto P13. Encadeamento. ]");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.WriteLine("*");
                    if (contadorColuna >= contadorLinha)
                        break;

                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
