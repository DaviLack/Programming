using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double qw, salario, cadaqw, pagar, desconto;

            Console.Write("Digite o valor do salário mínimo: R$ ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidades de quilowatts gasta: R$ ");
            qw = double.Parse(Console.ReadLine());

            cadaqw = (salario / 7) / qw;

            pagar = cadaqw * qw;

            desconto = pagar - (pagar / 10);

            Console.WriteLine("O valor em reais de cada quilowatt é: R$ " + cadaqw);
            Console.WriteLine("O valor em reais a ser pago é de: R$ " + pagar);
            Console.WriteLine("Com desconto o valor é de: R$ " + desconto);
            Console.ReadLine();

               

        }
    }
}
