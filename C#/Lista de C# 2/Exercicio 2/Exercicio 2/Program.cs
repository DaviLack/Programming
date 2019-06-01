using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)

            
        {
            double preco;

            Console.Write("Digite o preço do produto: R$ ");
            preco = double.Parse(Console.ReadLine());

            preco = preco - ((preco * 9) / 100);

            Console.Write("O preço com desconto será de: R$ " + preco);
            Console.ReadLine();

        }
    }
}
