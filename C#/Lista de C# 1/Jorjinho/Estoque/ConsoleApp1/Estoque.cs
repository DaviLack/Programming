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
            int atual, maxima, minima, media;


            Console.Write("Digite a quantidade máxima: ");
            maxima = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade mínima: ");
            minima = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade atual: ");
            atual = int.Parse(Console.ReadLine());


            media = (maxima + minima) / 2;


            if(atual >= media)
            {
                Console.Write("Não efetuar a compra.");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Efetuar compra.");
                Console.ReadLine();
            }


        }
    }
}
