using System;

class jorje
{
	public static void Main()
	{
	int salario, reajuste, jorge;
	
	Console.Write("Digite o valor do salário: R$ ");
	salario = int.Parse(Console.ReadLine());
	
	Console.Write("Digite o percentual do reajuste: ");
	reajuste = int.Parse(Console.ReadLine());
	
	
	jorge = (salario * reajuste) /100;
	salario = salario + jorge;
	
	Console.WriteLine("Seu novo salario será: R$ "+salario);
	
	}

}