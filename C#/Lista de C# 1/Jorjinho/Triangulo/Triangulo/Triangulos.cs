using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x, y, z;


            Console.Write("Digite a 1ª medida: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite a 2ª medida: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite a 3ª medida: ");
            c = int.Parse(Console.ReadLine());

            x = a + b;
            y = a + c;
            z = b + c;


            if(x >= c && y >= b && z >= a)
            {
                Console.Write("É possivel formar um triângulo");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Nâo é possivel formar um triângulo");
                Console.ReadLine();
            }

        }
    }
}
