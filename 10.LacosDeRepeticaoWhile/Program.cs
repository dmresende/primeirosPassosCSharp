using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LacosDeRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Executando o projeto 10. Laços de Repetição While" + "\n");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("No mês " + contadorMes + " você terá: R$" + valorInvestido);
                contadorMes++; //até o limite estabelecido ++ indicado para soma de mais 1
                //quando for somar de 2 em 2 ou 3 em 3 etc, usar o operador +=

            }

           Console.ReadLine();
        }
    }
}
