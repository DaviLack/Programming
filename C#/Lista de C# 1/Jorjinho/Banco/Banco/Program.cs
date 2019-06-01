using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorjinho
{
    class Banco
    {
        static void Main(string[] args)
        {
            int conta, saldo, debito, credito, saldoatual;

            Console.Write("Escreva o número da sua conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Escreva seu saldo: ");
            saldo = int.Parse(Console.ReadLine());

            Console.Write("Escreva seu débito: ");
            debito = int.Parse(Console.ReadLine());

            Console.Write("Escreva seu crédito: ");
            credito = int.Parse(Console.ReadLine());

            saldoatual = saldo - debito + credito;

            Console.WriteLine("Seu novo saldo é de: R$ " + saldoatual);

            if (saldoatual > 0)
            {
                Console.Write("Seu saldo está positivo parcero");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Seu saldo está negativo parcero");
                Console.ReadLine();
            }

        }
    }
}
