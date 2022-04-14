using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9. Escopo. ");

            int idade = 18;
            bool acompanhado = true;
            string mensagem;

            if (acompanhado == true)
            {
                mensagem = "Está acompanhando.";
                    
            } else
            {
                mensagem = "Não está acompanhado.";
            }

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode Entrar!");
                Console.WriteLine(mensagem);
            } else
            {
                Console.WriteLine("Não pode entrar!");
            }







            Console.ReadLine();
        }
    }
}
