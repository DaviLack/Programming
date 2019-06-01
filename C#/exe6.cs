using System;

class jorje
{
		public static void Main(){
		
			decimal carro, salario2, salario, salario1, comissao, finish, venda;
			
			Console.Write("Digite o valor de seu salario:");
			salario=decimal.Parse(Console.ReadLine());
			
			Console.Write("Digite o valor de carros vendidos:");
			carro=decimal.Parse(Console.ReadLine());
			
			Console.Write("Digite o valor da comissão:");
			comissao=decimal.Parse(Console.ReadLine());
			
			Console.Write("Digite o valor total das vendas:");
			venda=decimal.Parse(Console.ReadLine());
			
			
			salario2 = (venda * 5)/100;
			finish = carro * comissao;
			salario1 = salario + finish + salario2;
			
			
			Console.Write("O seu salario final é de: {0}",salario1);
		}
}		
			
			