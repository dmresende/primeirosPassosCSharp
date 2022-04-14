using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;
            Console.WriteLine("O salário é: R$" + salario + "\n");

            double divisaoResultadoFlutuante = 5.0 / 2;
            Console.WriteLine("double divisão 5.0 / 2 resultado: " + divisaoResultadoFlutuante + "\n");

            double divisaoResultadoTruncado = 5 / 2;
            Console.WriteLine("double divisão 5 / 2 resultado: " + divisaoResultadoTruncado + " [resultado truncado]" + "\n");

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            int brindes = 15;
            int pessoas = 2;
            Console.WriteLine(brindes / pessoas);
            //operações entre numeros inteiros sempre trará resultado inteiro;


            Console.WriteLine("Fim do programa, tecle [Enter] para encerrar...");
            Console.ReadLine();

        }
    }
}
