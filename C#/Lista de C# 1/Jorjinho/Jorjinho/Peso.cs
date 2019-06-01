using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorjinho
{
    class Peso
    {
        static void Main(string[] args)
        {
            double altura, peso;
            string nome;
            int sexo;
        

            Console.Write("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sexo (1 para Homem ou 2 para mulher): ");
            sexo = int.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());


            if (sexo == 1)
            {
                peso = (72.7 * altura) - 58;

                Console.WriteLine("Seu peso ideal é de: " + peso + "Kg");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para sair...");
                Console.Read();

            }

            else if(sexo == 2)
            {
                peso = (62.1 * altura) - 44.7;

                Console.WriteLine("Seu peso ideal é de: " + peso + "Kg");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para sair...");
                Console.Read();
            }

            else
            {
                Console.WriteLine("Você não digitou o sexo corretamente.");
                Console.WriteLine("");
                Console.WriteLine("Pressione ENTER para sair...");
                Console.Read();

            }
        }

    }
}
