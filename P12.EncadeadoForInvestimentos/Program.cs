using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.EncadeadoForInvestimentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ Executando projeto 11.  Encadendo for.");

            double valorIInvestido = 1000;
            double rendimento = 1.0036; //36%


            for(int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorIInvestido *= rendimento;
                }

                rendimento += 0.0010; //almento rendimentos
               
            }

           // Console.WriteLine("O tempo de investimento foi de " + )
            Console.WriteLine("Ao termino do investimento, você terá R$" + valorIInvestido);


            Console.ReadLine();
        }
    }
}
