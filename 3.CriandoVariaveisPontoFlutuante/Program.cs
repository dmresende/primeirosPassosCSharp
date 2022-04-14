using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3, Criando variáveis ponto flutuante");

            double salario = 1200.70;
            Console.WriteLine("Seu salário é: R$" + salario);

            double idade = 15; 
            Console.WriteLine("Sua idade é " + idade / 2 + "\n");

            int idadee = 15; //int quando divide numerro inteiro ele arredonda;
            Console.WriteLine("Sua idade é " + idadee / 2 + "\n");

            idade = 5 / 3; // Ele ignora o que vem depois da virgula  ATENÇÃO: não é ignorado;
            Console.WriteLine(idade);

            idade = 5.0 / 3; //ponto flutuante ele da o resultado com dízima;
            Console.WriteLine(idade);

            Console.WriteLine("A Execução acabou, tecle [Enter] para sair...");
            Console.ReadLine();

        }
    }
}
