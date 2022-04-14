using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2" + "\n");

            //definição da regra de nbegócio
            int maiorIdade = 18;
            int acompanhanteMaiorIdade = 0;

            //informações do cliente
            string nome = "Douglas";
            int idade = 16;
            string obs = "Obs.: Usando sinal de  || nas condicionais.";


            //impressão na tela das informações
            Console.WriteLine("***Convidados com nome na lista, se forem maior, não precisam de Acompranhante.***" + "\n" +
            "Nome: " + nome + "\n" + "Idade: " + idade + "\n" + "Número de acompanhantes maiores de idade: " + acompanhanteMaiorIdade);


            //regra condicional usando OU que se escreve ||
            if (idade >= maiorIdade || acompanhanteMaiorIdade >= 1)
            {
                Console.WriteLine("Você pode Entrar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar!!!");                
            }

            Console.WriteLine(obs + "\n");

            nome = "Natália";
            idade = 20;
            acompanhanteMaiorIdade = 0;
            obs = "Obs.: Usando sinal de && nas condicionais";

            Console.WriteLine("***Convidados sem nome na lista que devem trazer obrigatoriamente Acompranhante.***" + "\n" +
            "Nome: " + nome + "\n" + "Idade: " +  idade + "\n" + "Número de acompanhantes maiores de idade: " + acompanhanteMaiorIdade);
            

            if (idade >= maiorIdade && acompanhanteMaiorIdade >= 1)
            {
                Console.WriteLine("Você pode Entrar!! ");
            } else
            {
                Console.WriteLine("Infelizmente você não pode entrar! ");
            }

            Console.WriteLine(obs + "\n");

            nome = "Rosana  ";
            idade = 50;
            //bool acompanhado = acompanhanteMaiorIdade > 1;
            bool acompanhado = true;
            obs = "Usando Sinal de (ou) || e Boolean.";

            Console.WriteLine("***Convidados com nome na lista e maiores não precisam de acompanhantes para entrar!***" + "\n" +
            "Nome: " + nome + "\n" + "Idade: " + idade + "\n" + "Número de acompanhantes maior de idade: " + acompanhanteMaiorIdade);


            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode Entrar! ");
            } else
            {
                Console.WriteLine("Não pode entrar! ");
            }

            Console.WriteLine(obs + "\n");

            Console.Read();
        }
    }
}
