using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.WhilePoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Executando o projeto 11 While ] ");

            double valorInvestido = 1000;

           for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //Outra formas de simplificar a operação.
                //valorInvestido = valorInvestido + valorInvestido * 0.0036;
                // valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " mês você terá R$" + valorInvestido);
            }



            Console.ReadLine();
        }
    }
}
