using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            Console.Write("Digite o valor das despezas: ");
            preco = double.Parse(Console.ReadLine());

            preco = preco + (preco / 10);

            Console.WriteLine("Valor total a ser pago: " +preco);
            Console.ReadLine();
        }
    }
}
