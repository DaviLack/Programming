using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, letra;
            double preco;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o valor das despesas: R$ ");
            preco = int.Parse(Console.ReadLine());

            letra = nome.Substring(0, 1);

            if (letra == "A"|| letra == "D" || letra == "M" || letra == "S" || letra == "a" || letra == "d" || letra == "m" || letra == "s")
            {
                preco = preco - (preco * 0.30);

                Console.WriteLine("O valor com desconto será de: " + preco);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome, mas continue nos prestigiando que sua vez chegará");
                Console.ReadLine();
            }


        }
    }
}
