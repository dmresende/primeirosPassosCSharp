using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Executando o projeto 4]");

            //forçando entrada de valor flutuante em variável int.
            double salario = 1200.50;
            Console.WriteLine(salario);

            //nome dessa conversão é casting
            int salarioEmInteiro = (int)salario; 
            Console.WriteLine("Salário em int: " + salarioEmInteiro);

            //limite para armazenamento variável int 2³¹, 32bits
            int idade = 1300000000;
            Console.WriteLine("Numeros inteiro: " + idade);

            //variável para numeros longos 64bits;
            long numerosLongos = 1300000000000000000;
            Console.WriteLine("Numeros longos [variável long]: " + numerosLongos);

            //variável de 16bits
            short numerosCurtos = 15000;
            Console.WriteLine("Numeros curtos [ variável short]: " + numerosCurtos);
            
            //variável para casas decimais pequenas, coloca-se o "f" no final.
            float numerosPoucasCasaDecimais = 1.80f;
            Console.WriteLine("Numeros com poucas casas decimais, pouca precisão [ variável float ]:" + numerosPoucasCasaDecimais);


            Console.ReadLine();
        }
    }
}
