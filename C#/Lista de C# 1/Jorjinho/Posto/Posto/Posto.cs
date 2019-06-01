using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posto
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros, preco, desconto;
            char tipo;

            Console.Write("Digite a quantidade de gasolina: ");
            litros = double.Parse(Console.ReadLine());

            Console.Write("Digite o tipo de combústivel, use A para Alcool e G para Gasolina: ");
            tipo = char.Parse(Console.ReadLine());

            if (litros > 20)
            {
                if (tipo == 'A' || tipo == 'a')
                {
                    desconto = 2.90 - (2.90 * 5) / 100;
                    
                    preco = litros * desconto;

                    Console.Write("O preço total a ser pago é de: " + preco);
                    Console.ReadLine();

                }
                if (tipo == 'G' || tipo == 'g')
                {
                    desconto = 3.30 - (3.30 * 4) / 100;

                    preco = litros * desconto;

                    Console.Write("O preço total a ser pago é de: R$ " + preco);
                    Console.ReadLine();

                }
            }

            else if(litros <= 20)
            {
                if(tipo =='A' || tipo == 'a')
                {
                    desconto = 2.90 - (2.90 * 3) / 100;

                    preco = litros * desconto;

                    Console.Write("O preço total a ser pago é de: R$ " + preco);
                    Console.ReadLine();

                }
                if (tipo == 'G' || tipo == 'g')
                {
                    desconto = 3.30 - (3.30 * 6) / 100;

                    preco = litros * desconto;

                    Console.Write("O preço total a ser pago é de: " + preco);
                    Console.ReadLine();

                }

            }
        }   
    }
}
