using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double constante, mes, taxa, valor, jorje, kleber;

            Console.Write("Digite o valor constante da aplicação mensal: R$ ");
            constante = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de meses: ");
            mes = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa: ");
            taxa = double.Parse(Console.ReadLine());

            kleber = taxa + 1;

            jorje = Math.Pow(kleber, mes);

            valor = constante * (jorje - 1) / taxa;

            Console.Write("O valor do rendimento é de R$ " + valor);
            Console.ReadLine();



        }
    }
}
