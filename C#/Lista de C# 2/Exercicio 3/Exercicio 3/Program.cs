using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double horaaula, mes, inss, salario;

            Console.Write("Digite o valor da hora aula: ");
            horaaula = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de aulas por mês: ");
            mes = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de desconto do INSS: ");
            inss = double.Parse(Console.ReadLine());

            salario = horaaula * mes;

            salario = salario - ((salario * inss) / 100);

            Console.WriteLine("O valor líquido do salário desse professor é de R$ " + salario);
            Console.ReadLine();
        }
    }
}
