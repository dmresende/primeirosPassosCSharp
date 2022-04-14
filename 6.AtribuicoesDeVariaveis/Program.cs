using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ EXECUTANDO O PROJETO ATRIBUIÇOES DE VARIÁVEIS ]  ");

            // uma variável que recebe o valor de outra, recebe seu valor, porém mudado o valor da variável raiz, a herdeira não mais recebe atualização..
            int idade = 32;
            int idadeHerdeira = idade;

            idade = 20;

            Console.WriteLine("Idade Raiz: " + idade);
            Console.WriteLine("Idade herdeira:"  + idadeHerdeira);


            string parcela1 = "10";
            string parcela2 = "20";

            Console.WriteLine(parcela1 + parcela2);

            Console.ReadLine(); 

        }
    }
}
