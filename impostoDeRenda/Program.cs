using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("[ VEJA SUA ALÍQUOTA DE IR ] ");

            double salario = 5000;
            double aliquota1 = salario * 0.15;
            double aliquota2 = salario * 0.225;
            double aliquota3 =salario * 0.275;
            //bool contribuinte = true;
            string mensagem = "Sua Aliquota é de 15% e sua contribuição será de: R$";

            string nome = "Ivilasio Conrado";
            string empresa = "Contado Placas Eireli";

            Console.WriteLine("Nome: " + nome + "\n" + "Remuneração: R$" + salario + "\n" + "Empresa: " + empresa + "\n");

            if (salario >= 3300.01 && salario <= 4250)
            {
                Console.WriteLine(mensagem + aliquota1);

            } else if (salario >=4250.01 && salario <= 5300)
            {
                Console.WriteLine(mensagem + aliquota2);

            } else if (salario >= 5300.01)
            {
                Console.WriteLine(mensagem + aliquota3);

            } else
            {
                Console.WriteLine("Você não se classifica como contribuinte! ");
            }

            


            Console.ReadLine();
        }
    }
}
