using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_24_04
{
    public class Programa
    {
        public static void Main()
        {
            double A, N, X;

            Console.Write("Digite um valor A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite um valor N: ");
            N = double.Parse(Console.ReadLine());

            X = A;



            do
            {
                N = N - 1;

                X = X + 1;

                A = A + X;

            } while (N > 1);

            Console.Write("O valor total será de: " + A);
            Console.ReadLine();


            ConsoleKey resposta;

            do
            {
                Console.Write("Você deseja executar este programa novamente? [y/n]: ");
                resposta = Console.ReadKey(false).Key;   
                if (resposta != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (resposta != ConsoleKey.Y && resposta != ConsoleKey.N);

            if (resposta == ConsoleKey.Y)
            {

                Console.Write("Você deseja utilizar somente números pares ou somente ímpares? [p(ar) / i(impar) / n(ão)]: ");
                resposta = Console.ReadKey(false).Key;
                if (resposta != ConsoleKey.Enter)
                    Console.WriteLine();

                while (resposta != ConsoleKey.I && resposta != ConsoleKey.N && resposta != ConsoleKey.P) ;



                if (resposta == ConsoleKey.N)
                {

                    Programa.Main();
                }

                else if (respota == ConsoleKey.P)
                {
                    Programa.Par();
                }

                else
                {
                    Programa.Impar();
                }
            }
            else
            {
				Environment.Exit();
				Console.Write("Você deseja utilizar somente números pares ou somente ímpares? [p(ar) / i(impar) / n(ão)]: ");
			}




        }

            
















        }
    }
}
